import { classify } from '@/Classification'
import { asPoint, build } from '@/TypeConstructors'
import { expect } from 'chai'
import { it } from 'mocha'

describe('Line Segment', () => {
    it('should contain the points that constructed it', () => {
        const p1 = asPoint(0, 0)
        const p2 = asPoint(50, 0)

        var result = classify([p1, p2]) 
        expect((Math.abs(result.p1.x - p1.x) <= 0.001) && (Math.abs(result.p1.y - p1.y) <= 0.001), 'P1').to.be.true
        expect((Math.abs(result.p2.x - p2.x) <= 0.001) && (Math.abs(result.p2.y - p2.y) <= 0.001), 'P2').to.be.true
    })

    it('should contain different points that created it', () => {
        const p1 = asPoint(25, -3)
        const p2 = asPoint(-20, 11)

        var result = classify([p1, p2]) 
        expect((Math.abs(result.p1.x - p1.x) <= 0.001) && (Math.abs(result.p1.y - p1.y) <= 0.001), 'P1').to.be.true
        expect((Math.abs(result.p2.x - p2.x) <= 0.001) && (Math.abs(result.p2.y - p2.y) <= 0.001), 'P2').to.be.true
    })

    it('should contain a length when given points (0, 0) and (0, 5)', () => {
        const points = build(
            [0, 0],
            [0, 5],
        )

        const result = classify(points) 
        expect(result.length).to.be.closeTo(5, 0.001)
    })

    it('should contain a length when given points (0, 0) and (50, 0)', () =>{
        const points = build(
            [0, 0],
            [50, 0],
        )

        const result = classify(points) 
        expect(result.length).to.be.closeTo(50, 0.001)
    })

    it('should contain length when given points (1, 4) and (5, 7)', () => {
        const points = build(
            [1, 4],
            [5, 7],
        )

        const result = classify(points) 
        expect(result.length).to.be.closeTo(5, 0.001)
    })

    it('should have a slope of zero when both points have y of 4', () => {
        const y = 4
        const points = build(
            [1, y],
            [5, y],
        )

        const result = classify(points) 
        expect(result.slope).to.be.closeTo(0, 0.001)
    })

    it('should have a slope of zero when both points have y of -30', () => {
        const y = -30
        const points = build(
            [80, y],
            [-6, y],
        )

        const result = classify(points) 
        expect(result.slope).to.be.closeTo(0, 0.001)
    })

    it('should have a slope of One when x and y change by the same amount', () => {
        const change = 4
        const x = 1
        const y = 4
        const points = build(
            [x, y],
            [x + change, y + change]
        )

        const result = classify(points) 
        expect(result.slope).to.be.closeTo(1, 0.001)
    })

    it('should have a slope of -4', () => {
        const points = build(
            [0, 0],
            [-1, 4],
        )

        const result = classify(points) 
        expect(result.slope).to.be.closeTo(-4, 0.001)
    })

    it('should not have a slope if both points have an x of 3', () => {
        const x = 3
        const points = build(
            [x, 0],
            [x, 4],
        )

        const result = classify(points) 
        expect(result.slope).to.equal('Undefined')
    })

    it('should not have a slope if both points have an x of -51', () => {
        const x = -51
        const points = build(
            [x, 0],
            [x, 4],
        )

        const result = classify(points) 
        expect(result.slope).to.equal('Undefined')
    })
})