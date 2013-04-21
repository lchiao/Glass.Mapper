﻿using System;
using System.Linq.Expressions;
using Glass.Mapper.Sc.RenderField;

namespace Glass.Mapper.Sc.Web.Ui
{
    /// <summary>
    /// Class UiUtilities
    /// </summary>
    public static class UiUtilities
    {


        /// <summary>
        /// Makes a field editable via the Page Editor. Use the Model property as the target item, e.g. model =&gt; model.Title where Title is field name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="glassHtml">The glass HTML.</param>
        /// <param name="model">The model.</param>
        /// <param name="field">The field.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.NullReferenceException">
        /// No field set
        /// or
        /// No model set
        /// </exception>
        public static string Editable<T>(IGlassHtml glassHtml, T model, Expression<Func<T, object>> field)
        {

            if (field == null) throw new NullReferenceException("No field set");

            if (model == null) throw new NullReferenceException("No model set");

            try
            {
                var result = glassHtml.Editable<T>(model, field);
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        /// <summary>
        /// Makes a field editable via the Page Editor. Use the Model property as the target item, e.g. model =&gt; model.Title where Title is field name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="glassHtml">The glass HTML.</param>
        /// <param name="model">The model.</param>
        /// <param name="field">The field.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.NullReferenceException">
        /// No field set
        /// or
        /// No model set
        /// </exception>
        public static string Editable<T>(IGlassHtml glassHtml,T model, Expression<Func<T, object>> field, string parameters)
        {
            if (field == null) throw new NullReferenceException("No field set");
            if (model == null) throw new NullReferenceException("No model set");

            try
            {
                var result = glassHtml.Editable<T>(model, field, parameters);
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Makes a field editable via the Page Editor. Use the Model property as the target item, e.g. model =&gt; model.Title where Title is field name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="glassHtml">The glass HTML.</param>
        /// <param name="model">The model.</param>
        /// <param name="field">The field.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.NullReferenceException">
        /// No field set
        /// or
        /// No model set
        /// </exception>
        public static string Editable<T>(IGlassHtml glassHtml, T model, Expression<Func<T, object>> field, AbstractParameters parameters)
        {

            if (field == null) throw new NullReferenceException("No field set");

            if (model == null) throw new NullReferenceException("No model set");

            try
            {
                var result = glassHtml.Editable<T>(model, field, parameters);
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        /// <summary>
        /// Makes a field editable via the Page Editor. Use the Model property as the target item, e.g. model =&gt; model.Title where Title is field name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="glassHtml">The glass HTML.</param>
        /// <param name="model">The model.</param>
        /// <param name="field">The field.</param>
        /// <param name="standardOutput">The standard output.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.NullReferenceException">
        /// No field set
        /// or
        /// No standardoutput set
        /// or
        /// No model set
        /// </exception>
        public static  string Editable<T>(IGlassHtml glassHtml,T model, Expression<Func<T, object>> field, Expression<Func<T, string>> standardOutput)
        {

            if (field == null) throw new NullReferenceException("No field set");

            if (standardOutput == null) throw new NullReferenceException("No standardoutput set");

            if (model == null) throw new NullReferenceException("No model set");

            try
            {
                var result = glassHtml.Editable<T>(model, field, standardOutput);
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        /// <summary>
        /// Makes a field editable via the Page Editor. Use the Model property as the target item, e.g. model =&gt; model.Title where Title is field name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="glassHtml">The glass HTML.</param>
        /// <param name="model">The model.</param>
        /// <param name="field">The field.</param>
        /// <param name="standardOutput">The standard output.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.NullReferenceException">
        /// No field set
        /// or
        /// No standardoutput set
        /// or
        /// No model set
        /// </exception>
        public static string Editable<T>(IGlassHtml glassHtml,T model, Expression<Func<T, object>> field, Expression<Func<T, string>> standardOutput, AbstractParameters parameters)
        {

            if (field == null) throw new NullReferenceException("No field set");

            if (standardOutput == null) throw new NullReferenceException("No standardoutput set");

            if (model == null) throw new NullReferenceException("No model set");

            try
            {
                var result = glassHtml.Editable<T>(model, field, standardOutput, parameters);
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
