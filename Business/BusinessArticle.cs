using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessArticle
    {
        public List<Article> listar()
        {
            List<Article> articleList;
            articleList = mappingArticle("select A.Id as id, Codigo, Nombre, A.Descripcion as Descripcion, ImagenUrl, M.Descripcion As Marca, C.Descripcion as Categoria, Precio, M.Id as MId, C.Id as CId from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria");

            return articleList;
        }

        private List<Article> mappingArticle(string query)
        {
            List<Article> articleList = new List<Article>();
            DataAccess data = new DataAccess();
            try
            {
                data.setQuery(query);
                data.executeRead();
                while (data.Reader.Read())
                {
                    Article articleAux = new Article();
                    articleAux.Id = (int)data.Reader["id"];
                    articleAux.Code = (string)data.Reader["Codigo"];
                    articleAux.Name = (string)data.Reader["Nombre"];
                    articleAux.Description = (string)data.Reader["Descripcion"];
                    articleAux.ImageURL = (string)data.Reader["ImagenUrl"];
                    articleAux.ArticleBrand = new Brand();
                    articleAux.ArticleBrand.Id = (int)data.Reader["MId"];
                    articleAux.ArticleBrand.Description = (string)data.Reader["Marca"];
                    articleAux.ArticleCategory = new Category();
                    articleAux.ArticleCategory.Id = (int)data.Reader["CId"];
                    articleAux.ArticleCategory.Description = (string)data.Reader["Categoria"];
                    articleAux.Price = (decimal)data.Reader["Precio"];

                    articleList.Add(articleAux);


                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.closeConnection();
            }



            return articleList;
        }
    }
}
