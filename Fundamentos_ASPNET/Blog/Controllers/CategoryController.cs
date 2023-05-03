using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("v1/categories")]
        public async Task<IActionResult> GetAsync(
            [FromServices] BlogDataContext context)
        {
            var categories = await context.Categories.ToListAsync();
            return Ok(categories);
        }

        [HttpGet("v1/categories/{id:int}")]
        public async Task<IActionResult> GetByIdAsync(
            [FromRoute] int id,
            [FromServices] BlogDataContext context)
        {
            var category = await context
                .Categories
                .FirstOrDefaultAsync(x => x.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost("v1/categories/")]
        public async Task<IActionResult> PostAsync(
            [FromBody] Category model,
            [FromServices] BlogDataContext context)
        {
            try
            {
                await context.Categories.AddAsync(model);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "05XE9 - Nao foi possivel incluir a categoria!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "05XE10 - Falha interna no servidor!");
            }
           

            return Created($"v1/categories/{model.Id}", model);
        }

        [HttpPut("v1/categories/{id:int}")]
        public async Task<IActionResult> PutAsync(
            [FromRoute] int id,
            [FromBody] Category model,
            [FromServices] BlogDataContext context)
        {
            try
            {
                var category = await context
                .Categories
                .FirstOrDefaultAsync(x => x.Id == id);

                if (category == null)
                {
                    return NotFound();
                }

                category.Name = model.Name;
                category.Slug = model.Slug;

                context.Categories.Update(category);
                await context.SaveChangesAsync();

                return Ok(model);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "05XE7 - Nao foi possivel alterar a categoria!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "05XE12 - Falha interna no servidor!");
            }
        }

        [HttpDelete("v1/categories/{id:int}")]
        public async Task<IActionResult> PutAsync(
            [FromRoute] int id,
            [FromServices] BlogDataContext context)
        {
            try
            {
                var category = await context
                .Categories
                .FirstOrDefaultAsync(x => x.Id == id);

                if (category == null)
                {
                    return NotFound();
                }

                context.Categories.Remove(category);
                await context.SaveChangesAsync();

                return Ok(category);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "05XE8 - Nao foi possivel excluir a categoria!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "05XE11 - Falha interna no servidor!");
            }
        }
}
