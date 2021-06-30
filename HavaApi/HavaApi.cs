using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HavaApi
{
    public static class HavaApi
    {
        private static List<SehirTip> sehirListe = null;

        public static SehirTip[] SehirListesiVer()
        {
            if (sehirListe?.Count > 0)
                goto son;

            sehirListe = new List<SehirTip>();

            var web = new HtmlWeb();
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc = web.Load("https://www.ntvhava.com/");

            IEnumerable<HtmlNode> nodes = doc.DocumentNode.Descendants().Where(n => n.HasClass("search-city-list-item-link"));

            foreach (var item in nodes)
            {
                sehirListe.Add(new SehirTip()
                {
                    href = item.GetAttributeValue("href", ""),
                    sehir = HttpUtility.HtmlDecode(item.GetDirectInnerText())
                });
            }

            son:
            return sehirListe.ToArray();
        }

        public static HavaDurumuSonuc HavaDurumu(string sehirAdi)
        {
            if (string.IsNullOrEmpty(sehirAdi))
                return new HavaDurumuSonuc() { Durum = "Şehir boş olamaz!" };

            if (sehirListe is null)
                SehirListesiVer();

            var sehir = sehirListe?.Find(x => x.sehir == sehirAdi);
            if (sehir is null)
                return new HavaDurumuSonuc() { Durum = "Sehir bulunamıyor!" };

            var web = new HtmlWeb();
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc = web.Load("https://www.ntvhava.com/" + sehir.href);

            var resp = new HavaDurumuSonuc() { Sehir = sehir.sehir };

            var resim = doc.DocumentNode.Descendants().Where(n => n.HasClass("search-content-img") && n.InnerHtml.Trim().Length > 0)?.FirstOrDefault();
            if (!(resim is null))
            {
                resp.SvgUrl = "https://www.ntvhava.com" + resim.ChildNodes[1].Attributes["src"].Value;
                resp.Durum = HttpUtility.HtmlDecode(resim.ChildNodes[1].Attributes["alt"].Value);
            }

            var enYuksek = doc.DocumentNode.Descendants().FirstOrDefault(x => x.HasClass("search-content-degree-big"))
                ?.InnerHtml;
            if (!string.IsNullOrEmpty(enYuksek))
                resp.EnYuksek = int.Parse(enYuksek.Trim().Substring(0, 2));

            var enDusuk = doc.DocumentNode.Descendants().FirstOrDefault(x => x.HasClass("search-content-degree-small"))
                ?.InnerHtml;

            if (!string.IsNullOrEmpty(enDusuk))
                resp.EnDusuk = int.Parse(enDusuk.Replace("/", "").Trim().Substring(0, 2));

            return resp;

        }


        public class SehirTip
        {
            public string href { get; set; }
            public string sehir { get; set; }
        }

        public class HavaDurumuSonuc
        {
            public string Sehir { get; set; } = "";
            public string Durum { get; set; } = "";
            public int EnYuksek { get; set; } = 0;
            public int EnDusuk { get; set; } = 0;
            public string SvgUrl { get; set; } = "";
        }
    }
}
