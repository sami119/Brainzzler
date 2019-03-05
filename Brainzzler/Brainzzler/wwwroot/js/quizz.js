(function (window, $) {
    var answerSheet = {
        answers: [],
        score: 0
    }; //answerSheet object - will be submitted upon test finish
    var questionShow = null;
    function initQuizz() {
        $("#quizz .question").hide();
        $("#quizz .question").first().show();
        questionShow = $("#quizz .question").first();
     
    }

    initQuizz();

    $("#quizz #submit-quizz").click(function () {
        //post request must happen here
        //$.post("/api/AnswerSheet/")
    });

    $("#quizz .answerButton").click(function () {
        var answerId = $(this).attr("data-id");
        var questionId = $(this).attr("data-question-id");
        var questionScore = $(this).attr("data-question-score");

        $.get("/api/Answers/" + answerId, {}, function (data) {
            if (data.correct) {
                console.log("Correct");
                answerSheet.score += questionScore;
            } else {
                alert(data.wrongText);
            }

            answerSheet.answers[questionId] = answerId;
            $("#quizz .question").hide();
            questionShow = questionShow.next();
            console.log(questionShow);
            if (questionShow.length > 0) {
                questionShow.show();
            } else {
                $("#quizz .submit-box").show();
            }
        }, "json");

        //check if answer is correct
        //show wrong/correct answer
        //if answer is wrong, show extra data
        //if correct, show next question
    });

})(window, jQuery);