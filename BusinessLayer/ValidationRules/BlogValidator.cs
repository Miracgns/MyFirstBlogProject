using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(X => X.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz");
            RuleFor(X => X.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Geçemezsiniz");
            RuleFor(X => X.BlogImage).NotEmpty().WithMessage("Blog Görselini Boş Geçemezsiniz");
            RuleFor(X => X.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 Karakterden  daha az veri giriniz");
            RuleFor(X => X.BlogTitle).MinimumLength(5).WithMessage("Lütfen 4Karakterden  daha fazla veri giriniz");

        }
    }
}
