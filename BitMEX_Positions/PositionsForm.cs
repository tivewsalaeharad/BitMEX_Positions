using Bitmex.Client.Websocket;
using Bitmex.Client.Websocket.Client;
using Bitmex.Client.Websocket.Requests;
using Bitmex.Client.Websocket.Websockets;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitMEX_Positions
{
    public partial class PositionsForm : Form
    {
        private readonly PropertyInfo[] PositionProperties = typeof(PositionItem).GetProperties();

        public PositionsForm()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);

            //Connecting to WebSocket
            var url = BitmexValues.ApiWebsocketUrl;
            using (var communicator = new BitmexWebsocketCommunicator(url))
            {
                communicator.Name = "Bitmex-1";
                communicator.ReconnectTimeout = TimeSpan.FromMinutes(10);
                communicator.ReconnectionHappened.Subscribe(type =>
                    Console.WriteLine($"Reconnection happened, type: {type.Type}"));

                using (var client = new BitmexWebsocketClient(communicator))
                {

                    client.Streams.InfoStream.Subscribe(info =>
                    {
                        Console.WriteLine($"Reconnection happened, Message: {info.Info}, Version: {info.Version:D}");
                        SendSubscriptionRequests(client).Wait();
                    });

                    SubscribeToStreams(client);

                    communicator.Start();

                    _ = StartPinging(client);
                    
                }
            }

        }

        private static async Task StartPinging(BitmexWebsocketClient client)
        {
            await Task.Delay(TimeSpan.FromSeconds(30));
            client.Send(new PingRequest());
        }

        private static async Task SendSubscriptionRequests(BitmexWebsocketClient client)
        {
            client.Send(new PingRequest());
            if (!string.IsNullOrWhiteSpace(AccessKeys.bitmexSecret))
                client.Send(new AuthenticationRequest(AccessKeys.bitmexKey, AccessKeys.bitmexSecret));
        }


        private void SubscribeToStreams(BitmexWebsocketClient client)
        {
            client.Streams.PositionStream.Subscribe(y => PopulateDataGridView());
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void SetupDataGridView()
        {

            PositionsGrid.ColumnCount = PositionProperties.Length;

            for (int i = 0; i < PositionProperties.Length; i++)
            {
                PositionsGrid.Columns[i].Name = PositionProperties[i].Name;
            }

        }

        private void PopulateDataGridView()
        {
            PositionsGrid.Rows.Clear();

            BitMEXApi bitmex = new BitMEXApi(AccessKeys.bitmexKey, AccessKeys.bitmexSecret);
            var positions = bitmex.GetPositionList();

            foreach (PositionItem position in positions)
            {
                if (position.isOpen)
                {
                    object[] data = new object[PositionProperties.Length];

                    for (int i = 0; i < PositionProperties.Length; i++)
                    {
                        data[i] = PositionProperties[i].GetValue(position);
                    }

                    PositionsGrid.Rows.Add(data);

                }

            }

        }
    }
}
