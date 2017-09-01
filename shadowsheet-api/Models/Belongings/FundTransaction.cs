namespace ShadowAPI.Models
{
    public class FundTransaction
    {
        public string Name { get; set; }
        public long Value { get; set; }
        public FundTransaction PreviousTransaction { get; set; }
        public long CurrentValue // Perhaps method, if conflicts with table struture
        {
            get
            {
                return Value + PreviousTransaction.Value; 
                //... Hmmm have to figure out smart way to chain Transaction without pulling out all the history of previous transaction and just getting the current value as a variable...
            }
        }

    }
}