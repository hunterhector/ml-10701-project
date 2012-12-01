The work of (Hirschman et al., 1999) initiated this series of work, and it reported an accuracy of 36.3% on answering the questions in the test stories.
P99-1042
Although there were a few other scoring met129 rics originally proposed in (Hirschman et al., 1999), all the metrics were found to correlate well with one another.
P99-1042
This metric is originally proposed by (Hirschman et al., 1999).
P99-1042
In prior work (Hirschman et al., 1999; Charniak et al., 2000; Riloffand Thelen, 2000) the number and type of information sources used for computation is specific to and rlifFerent for each question type.
P99-1042 W00-0601 W00-0603
• keywords in questions It has been observed in the work of (Riloff and Thelen, 2000) that certain words in a when or where question tend to indicate that the dateline is an ~n~wer sentence to the question.
W00-0603
In a related but independent effort, a group at MITRE has investigated question answering in the context of the reading comprehension task (Hirschman et al., 1999).
P99-1042
To evaluate our learning approach, we trained AQUAREA$ on the same development set of stories and tested it on the same test set of stories as those used in all past work on the reading comprehension task (Hirschman et al., 1999; Charniak et al., 2000; Riloffand Thelen, 2000; Wang et al., 2000).
P99-1042 W00-0601 W00-0603 W00-0605
As such, all subsequent work (Charniak et al., 2000; Riloff and Thelen, 2000; Wang et al., 2000) uses HumSent as the main scoring metric, and it is also the scoring metric that we adopted in this paper.
W00-0601 W00-0603 W00-0605
Naturally, our current work on question answering for the reading comprehension task is most related to those of (Hirschman et al., 1999; Charniak et al., 2000; Riloffand Thelen, 2000; Wang et al., 2000).
P99-1042 W00-0601 W00-0603 W00-0605
Subsequently, the work of (Riloffand Thelen, 2000) and (Chaxniak et al., 2000) improved the accuracy further to 39.7% and 41%, respectively.
W00-0603
For comparison, the HumSent scores reported in the work of (Hirschm~.n et al., 1999), (Charniak et al., 2000), (Riloff and Thelen, 2000), and (Wang et al., 2000) are 36.3%, 41%, 39.7%, and 14%, respectively.
W00-0601 W00-0603 W00-0605
One exception is the work of (Radev et al., 2000) at the TREC-8 QA track, which uses logistic regression to rank potential answers using a training set with seven features.
A00-1021
It has been observed in prior work (Charniak et al., 2000; Riloff and Thelen, 2000) that such sentences may be more likely to be the answer sentences to some question type (for example, dateline can answer to when questions).
W00-0601 W00-0603
Representation Our feature representation was designed to capture the information sources that prior work (Hirschman et al., 1999; Cha_niak et al., 2000; Riloff and Thelen, 2000) used in their computations or rules.
P99-1042 W00-0603
The one notable exception is the work of (Wang et al., 2000), which attempted a machine learning approach to question answering for the same reading comprehension task.
W00-0605
We designed these 4 features to capture information that will be helpful to the why questions, since it has been observed in prior work (Charniak et al., 2000; Riloff and Thelen, 2000) that the answer 127 sentence to a why question tends to follow (or precede) the sentence in the story that has the most number of word matches with the question.
W00-0601 W00-0603
The words used in (Riloff and Thelen, 2000) are "happen", "take place" "this", "story".
W00-0603
The TREC-8 QA test scores of (Radev et al., 2000) were also considerably lower than best QA test scores.
A00-1021
