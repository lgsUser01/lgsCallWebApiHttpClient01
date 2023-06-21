using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace lgsCallWebApiHttpClient01
{
    public partial class Form1 : Form
    {

        public class KyoriKm
        {
            public int ShuyouKyoriKm { get; set; }
            public int SaitanKyoriKm { get; set; }
            public string Error { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            this.textBoxWebApiUrl.Text = "https://haruka01.logistica.jp/lgsWebKiro01/api/K/";
            this.textBoxWebApiKey.Text = "ここにWebApiKey値をセットする"; // ここにWebApiKey値をセットする


            this.textBox起点.Text = "13102";
            this.textBox終点.Text = "27127";
        }

        private async void httpClient呼び出しToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Url作成
            string F = this.textBox起点.Text;
            string T = this.textBox終点.Text;
            string K = this.textBoxWebApiKey.Text;

            string WepApiUrl = this.textBoxWebApiUrl.Text;
            string Url = WepApiUrl + "?f=" + F + "&t=" + T + "&k=" + K;
            // WebApi呼び出し
            KyoriKm kyoriKm = await WebApiKyoriKm(Url);
            // 結果
            this.textBox主要距離Km.Text = kyoriKm.ShuyouKyoriKm.ToString();
            this.textBox最短距離Km.Text = kyoriKm.SaitanKyoriKm.ToString();
            this.textBoxError.Text = kyoriKm.Error;
        }

        private async Task<KyoriKm> WebApiKyoriKm(string Url)
        {

            // 【2】プロキシ認証の指定
            string strProxyServer = "ProxyServer"; //.Pstring.Empty;   // (1)サーバ名
            string strUserName = "ProxyUserName"; // string.Empty;  // (2)ユーザ名
            string strPassword = "ProxyPassword"; // string.Empty;  // (3)パスワード

            strProxyServer = "";


            HttpClientHandler httpClientHandler = new HttpClientHandler();

            WebProxy webProxy = new WebProxy();

            if (strProxyServer == "")
            {
                httpClientHandler.Proxy = null;
            }
            else
            {
                Uri newUri = new Uri(strProxyServer);
                webProxy.Address = newUri;
                webProxy.Credentials = new NetworkCredential(strUserName, strPassword);
                httpClientHandler.Proxy = webProxy;
            }

            //  HttpClientクラスのインスタンス(client)を生成
            HttpClient client = new HttpClient(handler: httpClientHandler, disposeHandler: true);


            KyoriKm kyoriKm = null;
            HttpResponseMessage response = await client.GetAsync(Url);

            if (response.IsSuccessStatusCode)
            {
                string strResponse = await response.Content.ReadAsStringAsync();
                kyoriKm = JsonSerializer.Deserialize<KyoriKm>(strResponse);

            }
            return kyoriKm;

        }
    }
}
