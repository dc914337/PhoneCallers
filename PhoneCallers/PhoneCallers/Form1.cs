using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneCallers.caller;
using PhoneCallers.cfg;
using PhoneCallers.proxy;
using PhoneCallers.request;
using PhoneCallers.request.textPreprocessors;

namespace PhoneCallers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public PhoneCaller phoneCaller;

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTestCfg();
            //phoneCaller = CfgLoader.Load<PhoneCaller>("phone_caller.cfg");
        }



        private void CreateTestCfg()
        {
            phoneCaller = new PhoneCaller(
                new ProxyPool()
                {
                    Proxies = new List<Proxy>() { new Proxy() { Url = "61.235.249.222", Port = 80 }, new Proxy() { Url = "24.157.37.61", Port = 8080 } }
                },
                new RequestGenerator()
                {
                    PhonePreprocessor = new PhonePreprocessor(),
                    Preprocessors = new List<RandomReplacement>()
                    {
                        new RandomTextPreprocessor() { ReplaceString = "{name}", RandomList = new List<string>() { "Андрей","Петр","Алексей" }},
                        new RandomTextPreprocessor() { ReplaceString = "{comment}",RandomList = new List<string>() { "Срочно позвоните","жду звонка" } },
                        new RandomNumberPreprocessor() { ReplaceString = "{0-3}", MinNumber = 0, MaxNumber = 3 }
                    }
                }
               ,
                new RequestTemplatesPool()
                {
                    RequestTemplates = new List<RequestTemplate>()
                    {
                        new RequestTemplate()
                        { Type = RequestType.Post,
                         Arguments = new List<Argument>()
                         {
                             new Argument("name","{name}"),
                             new Argument("phone","{name}"),
                             new Argument("to","{0-3}"),
                             new Argument("text","{comment}"),
                             new Argument("phone2",""),
                             new Argument("save","true")
                         }
                        }
                    }
                }

                );
            CfgLoader.Save("phone_caller.xml", phoneCaller);
        }
    }
}
