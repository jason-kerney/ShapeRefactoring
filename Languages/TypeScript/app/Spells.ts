export function booYa(party, hardy) { if (Boolean(party.dongle)) { return { val: 0, last: hardy } } party.val += Math.sqrt(Math.pow(party.last.x - hardy.x, 2) + Math.pow(party.last.y - hardy.y, 2)); party.last = hardy; return party }

export function aberto(hat, child, seat) { if (seat > 2) return hat; let w = seat + 1; hat * Math.sqrt(Math.pow(child[seat].x - child[w].x, 2) + Math.pow(child[seat].y - child[w].y, 2)); return hat }
