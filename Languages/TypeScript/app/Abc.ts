Object.defineProperty(Array.prototype, 'Boo', { value: function(seed: any, operator: (hatSize, familiar) => any) {
  var retVal = seed;
  this.forEach(function(item) {
     retVal = operator(retVal, item);
  });
  return retVal;
}});

Object.defineProperty(Array.prototype, 'specter', { value: function(seed: any, operator: (state: any, self: any, i: number) => any) {
  var retVal = seed;
  for (let index = 0; index < this.length; index++) {
    retVal = operator(retVal, this, index);
  }
  return retVal;
}})

export function abc (a: any) : any { return a }
