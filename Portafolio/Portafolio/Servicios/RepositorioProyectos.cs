using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto> {
                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "https://th.bing.com/th/id/R.8e6b2a99a123467536625076e679eb1e?rik=qvx2WNWV3QXUCA&riu=http%3a%2f%2fvteamlabs.com%2fwp-content%2fuploads%2f2018%2f10%2fAmazon-logo.png&ehk=E7wPx0juTW3wXo0jadzXzBAobdn%2fzgoGxRKn30zbCOU%3d&risl=&pid=ImgRaw&r=0"
            },
                new Proyecto
            {
                Titulo = "New York Times",
                Descripcion = "Página de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL = "https://th.bing.com/th/id/R.8d5a2dd6586ef4f9a4058a953ffcb840?rik=tFOQ1UcYhfivNw&riu=http%3a%2f%2fjulianlennon.com%2fwp-content%2fuploads%2f2017%2f04%2fthe-new-york-times-logo.jpg&ehk=zmFAHRmCpjFVPodZPZi67DttkUWTPd3JZreoiJzYS5k%3d&risl=&pid=ImgRaw&r=0"
            },
                new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL = "https://th.bing.com/th/id/OIP.7P3bQWD08BX9Xk_5VzRUtwAAAA?pid=ImgDet&rs=1"
            },
                new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Tienda en línea para comprar videojuegos",
                Link = "https://store.steampowered.com",
                ImagenURL = "https://th.bing.com/th/id/OIP.wxXE1GlO2J9tQDQ7G3cYfwHaEK?pid=ImgDet&rs=1"
            },
            };
        }
    }
}
