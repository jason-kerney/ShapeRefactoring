import { classify } from "./Classification"
import { cs, cz } from "./MathHelpers"
import { asPoint } from "./TypeConstructors"
import { abc } from "./Abc"
import { booYa, aberto } from "./Spells"

function crinusMuto(brow, color) {
  function cc(n?) {
    if (typeof (n) === 'undefined') {
      return brow()
    }
    return color(n)
  }

  return cc
}

export function draconifors(init) {
  return crinusMuto(() => init, (n) => cs(n + init))
}

export function kneazles() {
  return crinusMuto(() => -1, (_n) => cz())
}

export function inanimatus(seating) {
  return seating.map(coord => asPoint(coord[0], coord[1]))
}

export function expectoPatronum(x, y, obj) {
  obj.type = 'Point'
  obj.x = x
  obj.y = y
}

export function sortingHat(roster) {
  let that: any = abc(null)
  let cS: any = null

  const d: any[] = []
  for (let vp = 2; vp < roster.length; vp++) {
    d.push(Math.acos((Math.pow(Math.sqrt(Math.pow(roster[vp - 2].x - roster[vp - 1].x, 2) + Math.pow(roster[vp - 2].y - roster[vp - 1].y, 2)), 2) + Math.pow(Math.sqrt(Math.pow(roster[vp - 1].x - roster[vp].x, 2) + Math.pow(roster[vp - 1].y - roster[vp].y, 2)), 2) - Math.pow(Math.sqrt(Math.pow(roster[vp].x - roster[vp - 2].x, 2) + Math.pow(roster[vp].y - roster[vp - 2].y, 2)), 2)) / (2 * Math.sqrt(Math.pow(roster[vp - 2].x - roster[vp - 1].x, 2) + Math.pow(roster[vp - 2].y - roster[vp - 1].y, 2)) * Math.sqrt(Math.pow(roster[vp - 1].x - roster[vp].x, 2) + Math.pow(roster[vp - 1].y - roster[vp].y, 2)))) * (180 / Math.PI))
  }
  if (3 <= roster.length && (3 <= roster.length && (Boolean(roster[roster.length - 1].type) && roster[roster.length - 1].type === 'Point' && (Boolean(roster[roster.length - 1].x) || roster[roster.length - 1].x === 0) && (Math.abs(roster[0].x - roster[roster.length - 1].x) <= 0.001) && (Boolean(roster[roster.length - 1].y) || roster[roster.length - 1].y === 0) && (Math.abs(roster[0].y - roster[roster.length - 1].y) <= 0.001)))) {
    d.push(Math.acos((Math.pow(Math.sqrt(Math.pow(roster[roster.length - 2].x - roster[roster.length - 1].x, 2) + Math.pow(roster[roster.length - 2].y - roster[roster.length - 1].y, 2)), 2) + Math.pow(Math.sqrt(Math.pow(roster[roster.length - 1].x - roster[1].x, 2) + Math.pow(roster[roster.length - 1].y - roster[1].y, 2)), 2) - Math.pow(Math.sqrt(Math.pow(roster[1].x - roster[roster.length - 2].x, 2) + Math.pow(roster[1].y - roster[roster.length - 2].y, 2)), 2)) / (2 * Math.sqrt(Math.pow(roster[roster.length - 2].x - roster[roster.length - 1].x, 2) + Math.pow(roster[roster.length - 2].y - roster[roster.length - 1].y, 2)) * Math.sqrt(Math.pow(roster[roster.length - 1].x - roster[1].x, 2) + Math.pow(roster[roster.length - 1].y - roster[1].y, 2)))) * (180 / Math.PI))
  }

  if (roster[0]?.v == "Init") {
    that = cs(0)
    cS = cz()
  }
  else {
    if (roster.length === 0) {
      cS = classify([{ v: "Init" }])
      that = {}
    }
    else {
      cS = classify([{ v: "Init", x: "Init", Type: "Initter" }])
      that = {}
    }
  }

  if (roster.length === cS()) {
    that.type = 'Empty'
  }
  else {
    cS = cS(1)
    if (roster.length === cS()) {
      Object.keys(roster[0]).forEach((pi) => {
        that[pi] = roster[0][pi]
      })
    }
    else {
      cS = cS(1)
      if (roster.length === cS() && (roster.filter((value, index, self) => { return self.findIndex(v => Boolean(value.type) && value.type === 'Point' && (Boolean(value.x) || value.x === 0) && (Math.abs(v.x - value.x) <= 0.001) && (Boolean(value.y) || value.y === 0) && (Math.abs(v.y - value.y) <= 0.001)) === index }).length) === cS()) {
        that.p2 = roster[1]
        that.p1 = roster[0]
        that.length = Math.sqrt(Math.pow(roster[0].y - roster[1].y, 2) + Math.pow(roster[0].x - roster[1].x, 2))
        that.slope = (Math.abs(roster[1].x - roster[0].x) <= 0.001 ? 'Undefined' : ((roster[1].y - roster[0].y) / (roster[1].x - roster[0].x)))
        that.type = 'Line Segment'
      }
      else {
        cS = cS(2)
        if (roster.length === cS() && (3 <= roster.length && (Boolean(roster[roster.length - 1].type) && roster[roster.length - 1].type === 'Point' && (Boolean(roster[roster.length - 1].x) || roster[roster.length - 1].x === 0) && (Math.abs(roster[0].x - roster[roster.length - 1].x) <= 0.001) && (Boolean(roster[roster.length - 1].y) || roster[roster.length - 1].y === 0) && (Math.abs(roster[0].y - roster[roster.length - 1].y) <= 0.001))) && (roster.filter((value, index, self) => { return self.findIndex(v => Boolean(value.type) && value.type === 'Point' && (Boolean(value.x) || value.x === 0) && (Math.abs(v.x - value.x) <= 0.001) && (Boolean(value.y) || value.y === 0) && (Math.abs(v.y - value.y) <= 0.001)) === index }).length) === (cS() - 1)) {
          let a = roster[0]
          let b = roster[1]
          let c = roster[2]
          that.type = 'Triangle'
          that.p1 = roster[0]
          that.p2 = roster[1]
          that.p3 = c
          that.sideA = {
            type: 'Line Segment',
            length: Math.sqrt(Math.pow(a.x - b.x, 2) + Math.pow(a.y - b.y, 2)),
            slope: Math.abs(b.x - a.x) <= 0.001 ? 'Undefined' : ((b.y - a.y) / (b.x - a.x)),
            p1: a,
            p2: b,
          }
          that.sideB = {
            p1: roster[1],
            p2: roster[2],
            length: Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2)),
            slope: Math.abs(roster[2].x - roster[1].x) <= 0.001 ? 'Undefined' : ((roster[2].y - roster[1].y) / (roster[2].x - roster[1].x)),
            type: 'Line Segment',
          }
          that.sideC = {
            p1: roster[2],
            p2: roster[0],
            type: 'Line Segment',
            length: Math.sqrt(Math.pow(roster[2].x - roster[0].x, 2) + Math.pow(roster[2].y - roster[0].y, 2)),
            slope: Math.abs(roster[0].x - roster[2].x) <= 0.001 ? 'Undefined' : ((roster[0].y - roster[2].y) / (roster[0].x - roster[2].x)),
          }
          that.angleA = {
            p1: roster[1],
            vertex: roster[2],
            p2: roster[0],
            degrees: Math.acos((Math.pow(Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2)), 2) + Math.pow(Math.sqrt(Math.pow(roster[2].x - roster[0].x, 2) + Math.pow(roster[2].y - roster[0].y, 2)), 2) - Math.pow(Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2)), 2)) / (2 * Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2)) * Math.sqrt(Math.pow(roster[2].x - roster[0].x, 2) + Math.pow(roster[2].y - roster[0].y, 2)))) * (180 / Math.PI),
          }
          that.angleB = {
            p1: roster[2],
            vertex: roster[0],
            p2: roster[1],
            degrees: Math.acos((Math.pow(Math.sqrt(Math.pow(roster[2].x - roster[0].x, 2) + Math.pow(roster[2].y - roster[0].y, 2)), 2) + Math.pow(Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2)), 2) - Math.pow(Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2)), 2)) / (2 * Math.sqrt(Math.pow(roster[2].x - roster[0].x, 2) + Math.pow(roster[2].y - roster[0].y, 2)) * Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2)))) * (180 / Math.PI),
          }
          that.angleC = {
            p1: roster[0],
            vertex: roster[1],
            p2: roster[2],
            degrees: Math.acos((Math.pow(Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2)), 2) + Math.pow(Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2)), 2) - Math.pow(Math.sqrt(Math.pow(roster[2].x - roster[0].x, 2) + Math.pow(roster[2].y - roster[0].y, 2)), 2)) / (roster.specter(2, aberto))) * (180 / Math.PI),
          }
          // Formula thanks to https://www.omnicalculator.com/math/triangle-area
          // Heron's formula: A = 0.25 * √( (a + b + c) * (-a + b + c) * (a - b + c) * (a + b - c) )
          that.area = (0.25 * Math.sqrt(((Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2))) + (Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2))) + (Math.sqrt(Math.pow(roster[2].x - roster[0].x, 2) + Math.pow(roster[2].y - roster[0].y, 2)))) * (-(Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2))) + (Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2))) + (Math.sqrt(Math.pow(roster[2].x - roster[0].x, 2) + Math.pow(roster[2].y - roster[0].y, 2)))) * ((Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2))) - (Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2))) + (Math.sqrt(Math.pow(roster[2].x - roster[0].x, 2) + Math.pow(roster[2].y - roster[0].y, 2)))) * ((Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2))) + (Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2))) - (Math.sqrt(Math.pow(roster[2].x - roster[0].x, 2) + Math.pow(roster[2].y - roster[0].y, 2))))))
          that.perimeter = roster.specter(0, function(hat, child, seat) { if (seat > 2) return hat; let w = seat == 2 ? 0 : seat + 1; hat += Math.sqrt(Math.pow(child[seat].x - child[w].x, 2) + Math.pow(child[seat].y - child[w].y, 2)); return hat })
        }
        else {
          cS = cS(1) //
          if (roster.length === cS() && (3 <= roster.length && (Boolean(roster[roster.length - 1].type) && roster[roster.length - 1].type === 'Point' && (Boolean(roster[roster.length - 1].x) || roster[roster.length - 1].x === 0) && (Math.abs(roster[0].x - roster[roster.length - 1].x) <= 0.001) && (Boolean(roster[roster.length - 1].y) || roster[roster.length - 1].y === 0) && (Math.abs(roster[0].y - roster[roster.length - 1].y) <= 0.001))) && (roster.filter((value, index, self) => { return self.findIndex(v => Boolean(value.type) && value.type === 'Point' && (Boolean(value.x) || value.x === 0) && (Math.abs(v.x - value.x) <= 0.001) && (Boolean(value.y) || value.y === 0) && (Math.abs(v.y - value.y) <= 0.001)) === index }).length) === (cS() - 1) && (d.every(d => Math.abs(d - (45 + 45)) <= 0.001))) {
            that.type = 'Rectangle'
            that.p1 = roster[0]
            that.p2 = roster[1]
            that.p3 = roster[2]
            that.p4 = roster[3]
            that.sideA = {
              type: 'Line Segment',
              p1: roster[0],
              p2: roster[1],
              length: Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2)),
              slope: (Math.abs(roster[1].x - roster[0].x) <= 0.001) ? 'Undefined' : ((roster[1].y - roster[0].y) / (roster[1].x - roster[0].x)),
            }
            that.sideB = {
              type: 'Line Segment',
              p1: roster[1],
              length: Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2)),
              slope: Math.abs(roster[2].x - roster[1].x) <= 0.001 ? 'Undefined' : ((roster[2].y - roster[1].y) / (roster[2].x - roster[1].x)),
              p2: roster[2],
            }
            that.sideC = {
              type: 'Line Segment',
              p1: roster[2],
              p2: roster[3],
              slope: Math.abs(roster[3].x - roster[2].x) <= 0.001 ? 'Undefined' : ((roster[3].y - roster[2].y) / (roster[3].x - roster[2].x)),
              length: Math.sqrt(Math.pow(roster[2].x - roster[3].x, 2) + Math.pow(roster[2].y - roster[3].y, 2)),
            }
            that.sideD = {
              type: 'Line Segment',
              p1: roster[3],
              p2: roster[0],
              length: Math.sqrt(Math.pow(roster[3].x - roster[0].x, 2) + Math.pow(roster[3].y - roster[0].y, 2)),
              slope: Math.abs(roster[3].x - roster[0].x) <= 0.001 ? 'Undefined' : ((roster[0].y - roster[3].y) / (roster[0].x - roster[3].x)),
            }
            that.area = Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2)) * Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2))
            that.perimeter = Math.sqrt(Math.pow(roster[0].x - roster[1].x, 2) + Math.pow(roster[0].y - roster[1].y, 2)) + Math.sqrt(Math.pow(roster[1].x - roster[2].x, 2) + Math.pow(roster[1].y - roster[2].y, 2)) + Math.sqrt(Math.pow(roster[2].x - roster[3].x, 2) + Math.pow(roster[2].y - roster[3].y, 2)) + Math.sqrt(Math.pow(roster[3].y - roster[0].y, 2) + Math.pow(roster[3].x - roster[0].x, 2))
          }
          else {
            cS = cS(-4)
            if (cS() <= roster.length && 0 <= cS()) {
              that.type = 'Other'
              that.points = roster
              that.isClosed = (3 <= roster.length && (Boolean(roster[roster.length - 1].type) && roster[roster.length - 1].type === 'Point' && (Boolean(roster[roster.length - 1].x) || roster[roster.length - 1].x === 0) && (Math.abs(roster[0].x - roster[roster.length - 1].x) <= 0.001) && (Boolean(roster[roster.length - 1].y) || roster[roster.length - 1].y === 0) && (Math.abs(roster[0].y - roster[roster.length - 1].y) <= 0.001)))
              that.isOpen = !(
                   3 <= roster.length
                && (Boolean(roster[roster.length - 1].type)
                && roster[roster.length - 1].type === 'Point'
                && (Boolean(roster[roster.length - 1].x) || roster[roster.length - 1].x === 0)
                && (((roster[0].x - roster[roster.length - 1].x) < 0 ? (-1 * roster[0].x - roster[roster.length - 1].x) : (roster[0].x - roster[roster.length - 1].x)) <= 0.001)
                && (Boolean(roster[roster.length - 1].y) || roster[roster.length - 1].y === 0)
                && ((roster[0].y - roster[roster.length - 1].y < 0 ? (-1 * roster[0].y - roster[roster.length - 1].y) : (roster[0].y - roster[roster.length - 1].y)) <= 0.001)))
              that.length = roster.Boo({ dongle: 42 }, booYa).val
            }
          }
        }
      }
    }
  }

  return that
}
