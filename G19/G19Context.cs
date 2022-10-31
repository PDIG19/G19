using Microsoft.EntityFrameworkCore;
public class G19Context:DbContext
{ 
public G19Context(DbContextOptions<G19Context> options) : base(options)
    {

    }
}