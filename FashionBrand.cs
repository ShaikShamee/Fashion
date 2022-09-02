using Admin;
using Categories;
using Products;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Fashion
{
    public class FashionBrand
    {
        static void Main(string[] args)
        {
            SqlConnection scon = new SqlConnection("server=localhost;database=DBCustomer;integrated security = true");
            AdminPage adminPage = new AdminPage();
            adminPage.AdminDetails();
                       Console.WriteLine("Logged in Successfully");
                       Product product = new Product();
                       Category category = new Category();
                       category.showCategoryMenu();
                       product.ShowProductMenu();

                int choose = int.Parse(Console.ReadLine());
                        switch (choose)
                        {
                            case 0:
                                InsertCategoriesdel insertCategoriesdel = new InsertCategoriesdel(category.InsertCategories);
                                insertCategoriesdel.Invoke();
                                break;
                            case 1:
                                ShowCategoriesdel showCategoriesdel = new ShowCategoriesdel(category.ShowCategories);
                                showCategoriesdel.Invoke();
                                break;

                            case 2:
                                InsertProductdel insertProductdel = new InsertProductdel(product.InsertProduct);
                                insertProductdel.Invoke();
                                break;
                            case 3:
                                UpdateProductdel updateProductdel = new UpdateProductdel(product.UpdateProduct);
                                updateProductdel.Invoke();
                                break;
                            case 4:
                                DeleteProductdel deleteProductdel = new DeleteProductdel(product.DeleteProduct);
                                deleteProductdel.Invoke();
                                break;
                            case 5:
                                ShowProductdel showProductdel = new ShowProductdel(product.ShowProduct);
                                showProductdel.Invoke();
                                break;
                            case 6:
                                SearchProductdel searchProductdel = new SearchProductdel(product.SearchProduct);
                                searchProductdel.Invoke();
                                break;
                            default:
                                Console.WriteLine("There is no data available here");
                                break;
                        }
                        
                    }
                }
            }
            
      

