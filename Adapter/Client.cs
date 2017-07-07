using System.Collections.Generic;

namespace Adapter
{
    public class ThiredPartyBillingSystem
    {
        private ITarget _target;

        public ThiredPartyBillingSystem(ITarget target)
        {
            _target = target;
        }

        public void ShowEmployees()
        {
            foreach (var item in _target.GetEmployee())
            {
                System.Console.WriteLine(item);
            }
        }
    }
}