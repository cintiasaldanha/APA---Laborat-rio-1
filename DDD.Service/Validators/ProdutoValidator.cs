using System;
using FluentValidation;
using DDD.Domain.Entities;

namespace DDD.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
{
	public ProdutoValidator()
        {
	    RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });
		
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Is necessary to inform the Nome.")
                .NotNull().WithMessage("Is necessary to inform the Nome.");

            RuleFor(c => c.Codigo)
                .NotEmpty().WithMessage("Is necessary to inform the Codigo.")
                .NotNull().WithMessage("Is necessary to inform the Codigo.");

            RuleFor(c => c.Preco)
                .NotEmpty().WithMessage("Is necessary to inform the Preço.")
                .NotNull().WithMessage("Is necessary to inform the SKU.");

            RuleFor(c => c.SKU)
                .NotEmpty().WithMessage("Is necessary to inform the Preço.")
                .NotNull().WithMessage("Is necessary to inform the SKU.");
        }
			}
}