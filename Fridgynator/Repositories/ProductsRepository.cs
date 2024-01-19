using Fridgynator.Models;
using Microsoft.Extensions.Logging;
using SQLite;
using System.Diagnostics;

namespace Fridgynator.Repositories;

public class ProductsRepository
{
    private string dbPath;
    private SQLiteAsyncConnection con;

    public ProductsRepository(string dbPath)
    {
        this.dbPath = dbPath;
    }

    //create table if not created earlier
    private async Task Init()
    {
        if (con != null)
            return;

        con = new SQLiteAsyncConnection(dbPath);
        await con.CreateTableAsync<ProductsModel>();
    }

    public async Task AddProductAsync(ProductsModel product, string comment)
    {
        await Init();
        try
        {
            product.Comment = comment;
            await con.InsertAsync(product);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Exception: {ex.Message}");          
        }
    }

    public async Task<List<ProductsModel>> GetAllProductsAsync()
    {
        await Init();
        try
        {
            return await con.Table<ProductsModel>().ToListAsync();
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Exception: {ex.Message}");
            return null;
        }
    }

    public async Task UpdateProductsAsync(ProductsModel product)
    {
        await Init();
        try
        {
            await con.UpdateAsync(product);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Exception: {ex.Message}");
            
        }
    }

    public async Task DeleteProductAsync(ProductsModel product)
    {
        await Init();
        try
        {
            await con.DeleteAsync(product);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Exception: {ex.Message}");
            
        }
    }
}
