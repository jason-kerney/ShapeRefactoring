import { classify } from '@/Classification'
import { build } from '@/TypeConstructors'
import { expect } from 'chai'
import { it } from 'mocha'

function getShape(...coords: [number, number][]): [any[], any] {
    var points = build(...coords)
    return [points, classify(points) ]
}

describe('Other', () => {
    it('should contain the points that constructed it', () => {
        const [points, result] = getShape(
            [0, 0],
            [0, 0]
        )

        expect(result.points).to.have.members(points)
    })

    it('should contain the points when there are four distinct points', () => {
        const [points, result] = getShape(
            [0, 0],
            [0, 5],
            [3, 5],
            [0, 1],
        )

        expect(result.points).to.have.members(points)
    })

    it('should contain points for open shape with duplicate points', () => {
        const [points, result] = getShape(
            [0, 0],
            [0, 5],
            [0, 0],
            [0, 1],
        )

        expect(result.points).to.have.members(points)
    })

    it('should know that a closed shape is closed and not open', () => {
        const [_points, result] = getShape(
            [0, 0],
            [0, 3],
            [3, 3],
            [0, 0],
            [-3, 0],
            [-3, -3],
            [0, 0],
        )

        expect(result.isClosed, 'isClosed').to.be.true
        expect(result.isOpen, 'isOpen').to.be.false
    })

    it('should know that an open shape is open and not closed', () => {
        const [_points, result] = getShape(
            [0, 0],
            [0, 3],
            [3, 3],
            [0, 0],
            [-3, 0],
            [-3, -3],
        )

        expect(result.isOpen, 'isOpen').to.be.true
        expect(result.isClosed, 'isClosed').to.be.false
    })

    it('should have a length with three points', () => {
        const [_points, result] = getShape(
            [0, 0],
            [0, 3],
            [3, 3],
        )

        expect(result.length).to.be.closeTo(6, 0.001)
    })

    it('should have a length even with more points', () => {
        const [_points, result] = getShape(
            [ 0,  0],
            [ 0,  3],
            [ 3,  3],
            [ 3,  0],
            [ 0,  0],
            [-3,  0],
            [-3, -3]
        )

        expect(result.length).to.be.closeTo(18, 0.001)
    })
})