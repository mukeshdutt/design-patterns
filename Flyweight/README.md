
*Flyweight*
We create the similar types of an object many times, in that case, the huge amount of memory is consumed.  For overcoming this problem we use flyweight design pattern where we share similar types of object. Means at first-time application request to flyweight please give me the object of this class, in that case, flyweight check that if requested object is available in their cache then return from the cache to the requester if not then create an instance of that class adds that into cache then return requested layer.

**Intrinsic** Intrinsic states are things that are constant and are stored in memory.

**Extrinsic** Extrinsic states are things that are not constant and needs to be calculated on the fly, and are therefore not stored in the memory. 