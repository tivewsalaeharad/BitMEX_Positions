using System;
using System.Reflection;
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
