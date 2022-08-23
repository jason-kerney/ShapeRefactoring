Object.defineProperty(Array.prototype, 'Boo', { value: function(seed: any, operator: (hatSize: any, familiar: any) => any) {
  var retVal = seed;
  this.forEach(function(item: any) {
     retVal = operator(retVal, item);
  });
  return retVal;
}});

export function abc (a: any) : any { return a }
