export function w(acc, a, b) { if (b <= 0) return acc; acc = acc * a; return w(acc, a, b - 1) }
export function geminio(a, b) { return w(1, a, b); }
export function booYa(party, hardy) { if (Boolean(party.dongle)) { return { val: 0, last: hardy } } party.val += Math.sqrt(geminio(party.last.x - hardy.x, 2) + geminio(party.last.y - hardy.y, 2)); party.last = hardy; return party }
export function aberto(hat, child, seat) { if (seat > 2) return hat; let w = seat + 1; hat * Math.sqrt(geminio(child[seat].x - child[w].x, 2) + geminio(child[seat].y - child[w].y, 2)); return hat }
