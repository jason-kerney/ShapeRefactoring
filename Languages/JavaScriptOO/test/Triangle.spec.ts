import { classify } from '@/Classification'
import { asPoint, build } from '@/TypeConstructors'
import { expect } from 'chai'
import { it } from 'mocha'

describe('Triangle', ()=>{
    it('should contain the points that constructed it',() => {
        const p1 = asPoint(0, 0)
        const p2 = asPoint(0, 5)
        const p3 = asPoint(3, 5)

        const result = classify([p1, p2, p3, p1]) 

        expect((Math.abs(result.p1.x - p1.x) <= 0.001) && (Math.abs(result.p1.y - p1.y) <= 0.001), 'P1').to.be.true
        expect((Math.abs(result.p2.x - p2.x) <= 0.001) && (Math.abs(result.p2.y - p2.y) <= 0.001), 'P2').to.be.true
        expect((Math.abs(result.p3.x - p3.x) <= 0.001) && (Math.abs(result.p3.y - p3.y) <= 0.001), 'P3').to.be.true
    })

    it('should contain different points that constructed it', () => {
        const p1 = asPoint(60, 90)
        const p2 = asPoint(-1, 5)
        const p3 = asPoint(-50, -5)

        const result = classify([p1, p2, p3, p1]) 

        expect((Math.abs(result.p1.x - p1.x) <= 0.001) && (Math.abs(result.p1.y - p1.y) <= 0.001), 'P1').to.be.true
        expect((Math.abs(result.p2.x - p2.x) <= 0.001) && (Math.abs(result.p2.y - p2.y) <= 0.001), 'P2').to.be.true
        expect((Math.abs(result.p3.x - p3.x) <= 0.001) && (Math.abs(result.p3.y - p3.y) <= 0.001), 'P3').to.be.true
    })

    it('should have legs of 3,4 and 5', () =>{
        const points = build(
            [0, 0],
            [0, 3],
            [4, 3],
            [0, 0],
        )

        const result = classify(points) 

        expect(result.sideA.type).to.equal('Line Segment')
        expect((Math.abs(result.sideA.p1.x - points[0].x) <= 0.001) && (Math.abs(result.sideA.p1.y - points[0].y) <= 0.001), 'A.P1').to.be.true
        expect((Math.abs(result.sideA.p2.x - points[1].x) <= 0.001) && (Math.abs(result.sideA.p2.y - points[1].y) <= 0.001), 'A.P2').to.be.true
        expect(result.sideA.length).to.be.closeTo(3, 0.001)
        expect(result.sideA.slope).to.equal('Undefined')

        expect(result.sideB.type).to.equal('Line Segment')
        expect((Math.abs(result.sideB.p1.x - points[1].x) <= 0.001) && (Math.abs(result.sideB.p1.y - points[1].y) <= 0.001), 'B.P1').to.be.true
        expect((Math.abs(result.sideB.p2.x - points[2].x) <= 0.001) && (Math.abs(result.sideB.p2.y - points[2].y) <= 0.001), 'B.P2').to.be.true
        expect(result.sideB.length).to.be.closeTo(4, 0.001)
        expect(result.sideB.slope).to.closeTo(0, 0.001)

        expect(result.sideC.type).to.equal('Line Segment')
        expect((Math.abs(result.sideC.p1.x - points[2].x) <= 0.001) && (Math.abs(result.sideC.p1.y - points[2].y) <= 0.001), 'C.P1').to.be.true
        expect((Math.abs(result.sideC.p2.x - points[0].x) <= 0.001) && (Math.abs(result.sideC.p2.y - points[0].y) <= 0.001), 'C.P2').to.be.true
        expect(result.sideC.length).to.be.closeTo(5, 0.001)
        expect(result.sideC.slope).to.closeTo(0.75, 0.001)
    })

    it('should have legs of 12,16 and 20', () =>{
        const points = build(
            [0, 0],
            [0, 12],
            [16, 12],
            [0, 0],
        )

        const result = classify(points) 

        expect(result.sideA.type).to.equal('Line Segment')
        expect((Math.abs(result.sideA.p1.x - points[0].x) <= 0.001) && (Math.abs(result.sideA.p1.y - points[0].y) <= 0.001), 'A.P1').to.be.true
        expect((Math.abs(result.sideA.p2.x - points[1].x) <= 0.001) && (Math.abs(result.sideA.p2.y - points[1].y) <= 0.001), 'A.P2').to.be.true
        expect(result.sideA.length).to.be.closeTo(12, 0.001)
        expect(result.sideA.slope).to.equal('Undefined')

        expect(result.sideB.type).to.equal('Line Segment')
        expect((Math.abs(result.sideB.p1.x - points[1].x) <= 0.001) && (Math.abs(result.sideB.p1.y - points[1].y) <= 0.001), 'B.P1').to.be.true
        expect((Math.abs(result.sideB.p2.x - points[2].x) <= 0.001) && (Math.abs(result.sideB.p2.y - points[2].y) <= 0.001), 'B.P2').to.be.true
        expect(result.sideB.length).to.be.closeTo(16, 0.001)
        expect(result.sideB.slope).to.closeTo(0, 0.001)

        expect(result.sideC.type).to.equal('Line Segment')
        expect((Math.abs(result.sideC.p1.x - points[2].x) <= 0.001) && (Math.abs(result.sideC.p1.y - points[2].y) <= 0.001), 'C.P1').to.be.true
        expect((Math.abs(result.sideC.p2.x - points[0].x) <= 0.001) && (Math.abs(result.sideC.p2.y - points[0].y) <= 0.001), 'C.P2').to.be.true
        expect(result.sideC.length).to.be.closeTo(20, 0.001)
        expect(result.sideC.slope).to.closeTo(0.75, 0.001)
    })

    it('should be a right triangle if side lengths are 3 4 5', () => {
        const points = build(
            [0, 0],
            [0, 3],
            [4, 3],
            [0, 0],
        )

        const result = classify(points) 

        expect((Math.abs(result.angleA.p1.x - points[1].x) <= 0.001) && (Math.abs(result.angleA.p1.y - points[1].y) <= 0.001), 'angleA.p1').to.be.true
        expect((Math.abs(result.angleA.vertex.x - points[2].x) <= 0.001) && (Math.abs(result.angleA.vertex.y - points[2].y) <= 0.001), 'angleA.vertex').to.be.true
        expect((Math.abs(result.angleA.p2.x - points[0].x) <= 0.001) && (Math.abs(result.angleA.p2.y - points[0].y) <= 0.001), 'angleA.p2').to.be.true
        expect(result.angleA.degrees).to.be.closeTo(36.87, 0.001)

        expect((Math.abs(result.angleB.p1.x - points[2].x) <= 0.001) && (Math.abs(result.angleB.p1.y - points[2].y) <= 0.001), 'angleB.p1').to.be.true
        expect((Math.abs(result.angleB.vertex.x - points[0].x) <= 0.001) && (Math.abs(result.angleB.vertex.y - points[0].y) <= 0.001), 'angleB.vertex').to.be.true
        expect((Math.abs(result.angleB.p2.x - points[1].x) <= 0.001) && (Math.abs(result.angleB.p2.y - points[1].y) <= 0.001), 'angleB.p2').to.be.true
        expect(result.angleB.degrees).to.be.closeTo(53.13, 0.001)

        expect((Math.abs(result.angleC.p1.x - points[0].x) <= 0.001) && (Math.abs(result.angleC.p1.y - points[0].y) <= 0.001), 'angleC.p1').to.be.true
        expect((Math.abs(result.angleC.vertex.x - points[1].x) <= 0.001) && (Math.abs(result.angleC.vertex.y - points[1].y) <= 0.001), 'angleC.vertex').to.be.true
        expect((Math.abs(result.angleC.p2.x - points[2].x) <= 0.001) && (Math.abs(result.angleC.p2.y - points[2].y) <= 0.001), 'angleC.p2').to.be.true
        expect(result.angleC.degrees).to.be.closeTo(90, 0.001)
    })

    it('should have angles of 30, 60 and 90 degrees', () => {
        const a = 3
        const b = a * Math.sqrt(3)
        const points = build(
            [a, 0],
            [0, 0],
            [0, b],
            [a, 0],
        )

        const result = classify(points) 

        expect((Math.abs(result.angleA.p1.x - points[1].x) <= 0.001) && (Math.abs(result.angleA.p1.y - points[1].y) <= 0.001), 'angleA.p1').to.be.true
        expect((Math.abs(result.angleA.vertex.x - points[2].x) <= 0.001) && (Math.abs(result.angleA.vertex.y - points[2].y) <= 0.001), 'angleA.vertex').to.be.true
        expect((Math.abs(result.angleA.p2.x - points[0].x) <= 0.001) && (Math.abs(result.angleA.p2.y - points[0].y) <= 0.001), 'angleA.p2').to.be.true
        expect(result.angleA.degrees).to.be.closeTo(30, 0.001)

        expect((Math.abs(result.angleB.p1.x - points[2].x) <= 0.001) && (Math.abs(result.angleB.p1.y - points[2].y) <= 0.001), 'angleB.p1').to.be.true
        expect((Math.abs(result.angleB.vertex.x - points[0].x) <= 0.001) && (Math.abs(result.angleB.vertex.y - points[0].y) <= 0.001), 'angleB.vertex').to.be.true
        expect((Math.abs(result.angleB.p2.x - points[1].x) <= 0.001) && (Math.abs(result.angleB.p2.y - points[1].y) <= 0.001), 'angleB.p2').to.be.true
        expect(result.angleB.degrees).to.be.closeTo(60, 0.001)

        expect((Math.abs(result.angleC.p1.x - points[0].x) <= 0.001) && (Math.abs(result.angleC.p1.y - points[0].y) <= 0.001), 'angleC.p1').to.be.true
        expect((Math.abs(result.angleC.vertex.x - points[1].x) <= 0.001) && (Math.abs(result.angleC.vertex.y - points[1].y) <= 0.001), 'angleC.vertex').to.be.true
        expect((Math.abs(result.angleC.p2.x - points[2].x) <= 0.001) && (Math.abs(result.angleC.p2.y - points[2].y) <= 0.001), 'angleC.p2').to.be.true
        expect(result.angleC.degrees).to.be.closeTo(90, 0.001)
    })

    it('should have angles of 45,45, and 90 degrees', () =>{
        const change = 3
        const x = 0
        const y = 0
        const points = build(
            [x, y],
            [x + change, y],
            [x + change, y + change],
            [x, y],
        )

        const result = classify(points) 

        expect(result.angleA.degrees).to.be.closeTo(45, 0.001)
        expect(result.angleB.degrees).to.be.closeTo(45, 0.001)
        expect(result.angleC.degrees).to.be.closeTo(90, 0.001)
    })

    it('should have correct area for a triangle composed of angles of 30, 60 and 90 degrees', () =>{
        const a = 3
        const b = a * Math.sqrt(3)
        const points = build(
            [a, 0],
            [0, 0],
            [0, b],
            [a, 0],
        )

        const result = classify(points) 

        expect(result.area).to.be.closeTo(7.794, 0.001)
    })

    it('should have correct area for a triangle composed of angles of 45,45, and 90 degrees', () => {
        const change = 3
        const x = 0
        const y = 0
        const points = build(
            [x, y],
            [x + change, y],
            [x + change, y + change],
            [x, y],
        )

        const result = classify(points) 

        expect(result.area).to.be.closeTo(4.5, 0.001)
    })

    it('should have the correct area for a triangle with sides of 3,4, and 5', () => {
        const points = build(
            [0, 0],
            [0, 3],
            [4, 3],
            [0, 0]
        )

        const result = classify(points) 

        expect(result.area).to.be.closeTo(6, 0.001)
    })

    it('should have correct perimeter of an equilateral triangle', () =>{
        const a = 16
        const points = build(
            [0, 0],
            [a, 0],
            [a / 2, (Math.sqrt(3) * a) / 2],
            [0, 0],
        )

        const result = classify(points) 

        expect(result.perimeter).to.be.closeTo(a * 3, 0.001)
    })

    it('should have correct perimeter of 3,4,5 triangle', () =>{
        const points = build(
            [0, 0],
            [3, 0],
            [3, 4],
            [0, 0],
        )

        const result = classify(points) 

        expect(result.perimeter).to.be.closeTo(3 + 4 + 5, 0.001)
    })
})