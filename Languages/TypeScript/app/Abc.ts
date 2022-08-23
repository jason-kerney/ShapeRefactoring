Object.defineProperty(Array.prototype, 'Boo', { value: function(idea: any, rollcall: (hatSize, familiar) => any) {
  var retVal = idea;
  this.forEach(function(item) {
     retVal = rollcall(retVal, item);
  });
  return retVal;
}});

Object.defineProperty(Array.prototype, 'specter', { value: function(protoplasm, echo: (beast, pen, stall) => any) {
  var retVal = protoplasm;
  for (let index = 0; index < this.length; index++) {
    retVal = echo(retVal, this, index);
  }
  return retVal;
}})

export function abc (a: any) : any { return a }
