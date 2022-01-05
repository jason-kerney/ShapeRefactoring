import { classify } from '@/Classification'
import { asPoint, build } from '@/TypeConstructors'
import { expect } from 'chai'
import { it } from 'mocha'

function buildRectangle(x, y, width, height) {
    return build(
        [x, y],
        [x + width, y],
        [x + width, y + height],
        [x, y + height],
        [x, y]
    )
}

function random(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min
}

function buildRandomRectangle() {
    const width = random(1, 500)
    const height = random(1, 500)
    const x = random(0, 500)
    const y = random(0, 500);

    const points = buildRectangle(x, y, width, height);
    const result = classify(points) ;
    return { result, x, y, width, height };
}

describe('Rectangle', () => {
    it('should contain the points that constructed it', () => {
        const p1 = asPoint(0, 0);
        const p2 = asPoint(0, 3);
        const p3 = asPoint(4, 3);
        const p4 = asPoint(4, 0);

        const result = classify([p1, p2, p3, p4, p1]) ;

        expect((Math.abs(result.p1.x - p1.x) <= 0.001) && (Math.abs(result.p1.y - p1.y) <= 0.001), 'P1').to.be.true;
        expect((Math.abs(result.p2.x - p2.x) <= 0.001) && (Math.abs(result.p2.y - p2.y) <= 0.001), 'P2').to.be.true;
        expect((Math.abs(result.p3.x - p3.x) <= 0.001) && (Math.abs(result.p3.y - p3.y) <= 0.001), 'P3').to.be.true;
        expect((Math.abs(result.p4.x - p4.x) <= 0.001) && (Math.abs(result.p4.y - p4.y) <= 0.001), 'P4').to.be.true;
    });

    it('should contain line segments for its sides', () => {
        const points = buildRectangle(0, 0, 3, 4);

        const result = classify(points) ;

        expect(result.sideA.type).to.equal('Line Segment');
        expect((Math.abs(result.sideA.p1.x - points[0].x) <= 0.001) && (Math.abs(result.sideA.p1.y - points[0].y) <= 0.001), 'A.p1').to.be.true;
        expect((Math.abs(result.sideA.p2.x - points[1].x) <= 0.001) && (Math.abs(result.sideA.p2.y - points[1].y) <= 0.001), 'A.p2').to.be.true;

        expect(result.sideB.type).to.equal('Line Segment');
        expect((Math.abs(result.sideB.p1.x - points[1].x) <= 0.001) && (Math.abs(result.sideB.p1.y - points[1].y) <= 0.001), 'B.p1').to.be.true;
        expect((Math.abs(result.sideB.p2.x - points[2].x) <= 0.001) && (Math.abs(result.sideB.p2.y - points[2].y) <= 0.001), 'B.p2').to.be.true;

        expect(result.sideC.type).to.equal('Line Segment');
        expect((Math.abs(result.sideC.p1.x - points[2].x) <= 0.001) && (Math.abs(result.sideC.p1.y - points[2].y) <= 0.001), 'C.p1').to.be.true;
        expect((Math.abs(result.sideC.p2.x - points[3].x) <= 0.001) && (Math.abs(result.sideC.p2.y - points[3].y) <= 0.001), 'C.p2').to.be.true;

        expect(result.sideD.type).to.equal('Line Segment');
        expect((Math.abs(result.sideD.p1.x - points[3].x) <= 0.001) && (Math.abs(result.sideD.p1.y - points[3].y) <= 0.001), 'D.p1').to.be.true;
        expect((Math.abs(result.sideD.p2.x - points[0].x) <= 0.001) && (Math.abs(result.sideD.p2.y - points[0].y) <= 0.001), 'D.p2').to.be.true;
    });

    it('should contain different line segments for its sides', () => {
        const points = buildRectangle(1, 1, 3, 4);

        const result = classify(points) ;

        expect(result.sideA.type).to.equal('Line Segment');
        expect((Math.abs(result.sideA.p1.x - points[0].x) <= 0.001) && (Math.abs(result.sideA.p1.y - points[0].y) <= 0.001), 'A.p1').to.be.true;
        expect((Math.abs(result.sideA.p2.x - points[1].x) <= 0.001) && (Math.abs(result.sideA.p2.y - points[1].y) <= 0.001), 'A.p2').to.be.true;

        expect(result.sideB.type).to.equal('Line Segment');
        expect((Math.abs(result.sideB.p1.x - points[1].x) <= 0.001) && (Math.abs(result.sideB.p1.y - points[1].y) <= 0.001), 'B.p1').to.be.true;
        expect((Math.abs(result.sideB.p2.x - points[2].x) <= 0.001) && (Math.abs(result.sideB.p2.y - points[2].y) <= 0.001), 'B.p2').to.be.true;

        expect(result.sideC.type).to.equal('Line Segment');
        expect((Math.abs(result.sideC.p1.x - points[2].x) <= 0.001) && (Math.abs(result.sideC.p1.y - points[2].y) <= 0.001), 'C.p1').to.be.true;
        expect((Math.abs(result.sideC.p2.x - points[3].x) <= 0.001) && (Math.abs(result.sideC.p2.y - points[3].y) <= 0.001), 'C.p2').to.be.true;

        expect(result.sideD.type).to.equal('Line Segment');
        expect((Math.abs(result.sideD.p1.x - points[3].x) <= 0.001) && (Math.abs(result.sideD.p1.y - points[3].y) <= 0.001), 'D.p1').to.be.true;
        expect((Math.abs(result.sideD.p2.x - points[0].x) <= 0.001) && (Math.abs(result.sideD.p2.y - points[0].y) <= 0.001), 'D.p2').to.be.true;
    });

    it('should have correct area', () => {
        function check(result, x, y, width, height) {
            expect(result.area, `x: ${x}, y: ${y}, w: ${width}, h: ${height}`).to.be.closeTo(height * width, 0.001);
        }

        for (let index = 0; index < 100; index++) {
            const { result, x, y, width, height } = buildRandomRectangle();
            check(result, x, y, width, height);
        }
    });

    it('should have correct perimeter', () => {
        function check(result, x, y, width, height) {
            expect(result.perimeter, `x: ${x}, y:${y}, w:${width}, h: ${height}`).to.be.closeTo(2 * height + 2 * width, 0.001);
        }

        for (let index = 0; index < 100; index++) {
            const { result, x, y, width, height } = buildRandomRectangle();
            check(result, x, y, width, height);
        }
    });
});
