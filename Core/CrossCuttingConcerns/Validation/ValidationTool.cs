using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation {
    public static class ValidationTool {
        public static void Validate(IValidator validotor, object entity) {
            var context = new ValidationContext<object>(entity);
            var result = validotor.Validate(context);
            if (!result.IsValid) {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
