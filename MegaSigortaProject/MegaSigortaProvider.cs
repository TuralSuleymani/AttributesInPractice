using ProviderProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzercellProject
{
    [ProviderName("MegaSigorta")]
    public class MegaSigortaProvider
    {
        [ProviderOperation(EventType.Click)]
        public void OnButtonClicked()
        {
            //implementation simplified for learning..
            MessageBox.Show("This is Mega Sigorta provider");
        }
    }
}
