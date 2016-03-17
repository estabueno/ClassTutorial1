using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;

        [NonSerialized()]
        private static frmSculpture sculptDialog;

        public override void EditDetails()
        {
            if (sculptDialog == null)
            {
                sculptDialog = new frmSculpture();
            }
            sculptDialog.SetDetails(_Name, _Date, _Value, _Weight, _Material);
            if(sculptDialog.ShowDialog() == DialogResult.OK)
            {
                sculptDialog.GetDetails(ref _Name, ref _Date, ref _Value, ref _Weight, ref _Material);
            }
        }

    }
}
