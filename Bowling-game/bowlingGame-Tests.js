describe("Bowling Game", function () {
    it("Handle Gutter Game", function () {
        var game = new BowlingGame();
        for (var i = 0; i < 20; i++) {
            game.roll(0);
        }
        expect(game.score()).to.equal(0);
    });
});