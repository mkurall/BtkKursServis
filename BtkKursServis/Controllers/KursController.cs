using BtkKursServis.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BtkKursServis.Controllers
{
    [ApiController]
    [Route("api/v1/[action]")]
    public class KursController : ControllerBase
    {
        [HttpGet]
        public string Test()
        {
            return "Api ile bağlantı testi ok.";
        }

        [HttpPost]
        public int Topla(int a, int b)
        {
            return a + b;
        }

        [HttpGet]
        public List<Kurs> KurslariGetir()
        {
            using(KursDbContext ctx = new KursDbContext())
            {
                var list = ctx.Kurslar.ToList();
                return list;
            }
        }

        [HttpPost]
        public Kurs KursEkle(string ad)
        {
            using (KursDbContext ctx = new KursDbContext())
            {
                Kurs yeni = new Kurs() { Ad = ad };
                yeni.KursTarihi = DateTime.Now; 

                ctx.Kurslar.Add(yeni);
                ctx.SaveChanges();
                return yeni;
            }
        }

    }
}
