import { expectoPatronum, inanimatus } from "./utils"

export function build(...coords: [number, number][]) {
    return inanimatus(coords)
}

export function asPoint(x, y): any {
    let obj = {}
    expectoPatronum(x, y, obj)
    return obj
}

