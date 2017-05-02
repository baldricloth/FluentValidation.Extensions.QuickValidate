//Copyright 2017 Baldric Lothbrok

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

namespace FluentValidation.Extensions.QuickValidate
{
    /// <summary>
    /// Extension to easily invoke the validation of an object
    /// </summary>
    public static class ValidationExtension
    {
        /// <summary>
        /// Validate an data in an object using an Abstract Validator
        /// </summary>
        /// <typeparam name="V">Abstract Validator</typeparam>
        /// <typeparam name="T">ObjectType to Validate</typeparam>
        /// <param name="toValidate">Object to Validate</param>
        /// <returns></returns>
        public static ExtensionResult Validate<V, T>(this T toValidate) where V : class, new() where T : class
        {
            var validatorInstance = new V() as AbstractValidator<T>;
            var results = validatorInstance.Validate(toValidate);

            return new ExtensionResult
            {
                ValidationResult = results,
                IsValid = results.IsValid,
                ValidationFailures = results.Errors
            };
        }
    }
}
