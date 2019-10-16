using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayQuick.Domain.Models
{
    public abstract class ModelBase
    {
        private readonly Dictionary<string, object> _parameters;
        
        public string ApiKey
        {
            set => SetPropertyValue("apikey", value);
        }
        
        protected ModelBase()
        {
            _parameters = new Dictionary<string, object>();
        }
        
        protected void SetPropertyValue(string properyName, object value)
        {
            if (this._parameters.ContainsKey(properyName))
                this._parameters[properyName] = value;
            else
                this._parameters.Add(properyName, value);
        }

        internal Dictionary<string, string> ToDictionary()
        {
            return _parameters.ToDictionary(p => p.Key, p => p.Value.ToString());
        }
    }
}