using ProviderProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzercellProject
{
    [ProviderName("Azercell")]
    public class AzercellProvider
    {
        [ProviderOperation(EventType.Click)]
        public void OnButtonClicked()
        {
            //implementation simplified for learning..
            MessageBox.Show("This is Azercell provider");
        }
    }
}
