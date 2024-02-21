using ETicaretAPI.Application.WiewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator:AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull().WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(5).WithMessage("Lütfen ürün adını 5 ila 150 karakter arasında giriniz.");

            RuleFor(p => p.Stock)
                .NotNull()
                .NotEmpty()
                    .WithMessage("Lütfen stok bilgisini boş geçmeyiniz.")
                .Must(s => s >= 0)
                    .WithMessage("stok bilgisi 0 dan az olamaz");

            RuleFor(p => p.Price)
                .NotNull()
                .NotEmpty()
                    .WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz.")
                .Must(s => s >= 0)
                    .WithMessage("fiyat bilgisi 0 dan az olamaz");
        }
    }
}
