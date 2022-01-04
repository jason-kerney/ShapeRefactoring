import { classify } from '@/Classification'
import { build } from '@/TypeConstructors'
import { expect } from 'chai'
import { it } from 'mocha'
//import { configure } from "./utils/approvals"

//const approvals = configure()

describe('classify', () => {
    describe('basic shapes', () => {
        it('should classify an empty array as empty', () => {
            const points = build()
            var result = classify(points)
    
            expect(result.type).to.equal('Empty')
        })

        it('should classify a point as a point', () => {
            const points = build([0, 0])
            var result = classify(points)
            expect(result.type).to.equal('Point')
        })

        it('should classify a point as itself', () => {
            const points = build([0, 1])
            var result = classify(points)
            expect(Boolean(points[0].type) && points[0].type === 'Point' && (Boolean(points[0].x) || points[0].x === 0) && (Math.abs(result.x - points[0].x) <= 0.001) && (Boolean(points[0].y) || points[0].y === 0) && (Math.abs(result.y - points[0].y) <= 0.001)).to.be.true
        })
    })

    describe('line segment', () => {
        it('should classify two different points as a line segment', () => {
            const points = build(
                [0, 0],
                [0, 3],
            )

            var result = classify(points)
            expect(result.type).to.equal('Line Segment')
        })

        it('should classify two points in the same location as other', () => {
            const points = build(
                [90, -10],
                [90, -10],
            )

            var result = classify(points)
            expect(result.type).to.equal('Other')
        })
    })

    describe('triangle', () => {
        it('should classify four points where the first three are distinct and the first and last point are the same as a triangle', () => {
            const points = build(
                [0, 0],
                [0, 5],
                [3, 5],
                [0, 0],
            )

            const result = classify(points)
            expect(result.type).to.equal('Triangle')
        })

        it('should classify four points that form an open shape as other', () =>{
            const points = build(
                [0, 0],
                [0, 5],
                [3, 5],
                [4, 4],
            )

            const result = classify(points)
            expect(result.type).to.equal('Other')
        })

        it('should classify four points that form a closed shape with duplicate points as other', () => {
            const points = build(
                [0, 0],
                [0, 5],
                [0, 5],
                [0, 0],
            )

            const result = classify(points)
            expect(result.type).to.equal('Other')
        })
    })

    describe('rectangle', () => {
        it('should classify a closed shape formed with 4 distinct points as a rectangle', () => {
            const points = build(
                [0, 0],
                [0, 4],
                [3, 4],
                [3, 0],
                [0, 0],
            )

            const result = classify(points)
            expect(result.type).to.equal('Rectangle')
        })

        it('should classify an open shape composed of five points as other', () => {
            const points = build(
                [0, 0],
                [0, 4],
                [3, 4],
                [3, 0],
                [5, 5],
            )

            const result = classify(points)
            expect(result.type).to.equal('Other')
        })

        it('should classify a closed shape formed of five points with repeated points as other', () => {
            const points = build(
                [0, 0],
                [0, 4],
                [3, 4],
                [3, 4],
                [0, 0],
            )

            const result = classify(points)
            expect(result.type).to.equal('Other')
        })

        it('should classify a closed shape formed of six points with one duplicate as other', () => {
            const points = build(
                [0, 0],
                [0, 5],
                [4, 5],
                [4, 0],
                [4, 5],
                [0, 0],
            )

            const result = classify(points)
            expect(result.type).to.equal('Other')
        })

        it('should classify a closed shape formed of five distinct points where the angles are not all right as other', () =>{
            const points = build(
                [0, 0],
                [1, 4],
                [3, 4],
                [3, 1],
                [0, 0],
            )

            const result = classify(points)
            expect(result.type).to.equal('Other')
        })
    })
})