using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace WindowsApplication3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void chartControl1_ObjectHotTracked(object sender, DevExpress.XtraCharts.HotTrackEventArgs e) {
            // Display the object's type.
            this.Text = e.Object.GetType().ToString();
            // Display the additional object's type, when it is available.
            if (e.AdditionalObject != null) {
                this.Text += " (" + e.AdditionalObject.GetType().ToString() + ")";
            }
        }

        private void chartControl1_ObjectSelected(object sender, DevExpress.XtraCharts.HotTrackEventArgs e) {
            // Prevent the chart's diagram from being selected.
            if (e.Object is XYDiagram) {
                e.Cancel = true;
            }
            else {
                MessageBox.Show(e.Object.GetType().ToString());
            }
        }
    }
}