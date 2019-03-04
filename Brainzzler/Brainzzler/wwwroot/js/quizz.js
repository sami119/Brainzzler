(function (window, $) {
    var Quizz = function () {
        this.answers = [];
        this.correctAnswers = [];
        this.questionId = null;
        this.totalScore = 0;
        this.quizzContainer = null;
    };

    Quizz.prototype = {
        init: function () {
            this.answers = [];
            this.questionId = null;
            this.totalScore = 0;
            this.quizzContainer = null;
            return this;
        },
        setQuizzContainer: function (quizzContainer) {
            this.quizzContainer = quizzContainer;
        },
        submitAnswers: function (questionId) {

        },
        getQuestion: function (questionId) {

        },
        //добавяме css клас за маркиране на отговорите на потребителя
        highLightAnswers: function () {
            $(this.quizzContainer).find(".answer").removeClass("selected");
            $(this.answers).each(function (index, element) {
                $(this.quizzContainer).find(".answer[data-id='" + element + "']").addClass("selected");
            });
        },
        highLightCorrectAnswers: function () {
            $(this.quizzContainer).find(".answer").removeClass("correct");
            $(this.corectAnswers).each(function (index, element) {
                $(this.quizzContainer).find(".answer[data-id='" + element + "']").addClass("correct");
            });
        }
        //...
    };

    $.fn.Quizz = function () {
        return this.each(function (index, element) {
            new Quizz(this).init();
        });
    };

    window.Quizz = Quizz;
})(window, jQuery);