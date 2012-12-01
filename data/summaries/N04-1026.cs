Lexical information has been shown to improve speech-based emotion prediction in other domains (Litman et al., 2001; Lee et al., 2002; Ang et al., 2002; Batliner et al., 2003; Devillers et al., 2003; Shafran et al., 2003), so our rst non-acoustic-prosodic feature represents the transcription3 of each student turn as a word occurrence vector (indicating the lexical items that are present in the turn).
P01-1048
The number of words and syllables in a turn provide alternative ways to quantify turn duration (Litman et al., 2001).
P01-1048
Context-Level Features Research in other domains (Litman et al., 2001; Batliner et al., 2003) has shown that features representing the dialogue context can sometimes improve the accuracy of predicting negative user states, compared to the use of features computed from only the turn to be predicted.
P01-1048
Dialogue System and Corpus We are currently building a spoken dialogue tutorial system called ITSPOKE (Intelligent Tutoring SPOKEn dialogue system) (Litman and Silliman, 2004), with the goal of automatically predicting and adapting to student emotions.
N04-3002 W04-2326
We have developed an annotation scheme for hand labeling the student turns in our corpus with respect to three types of perceived emotions (Litman and Forbes-Riley, 2004): Negative: a strong expression of emotion such as confused, bored, frustrated, uncertain.
N04-3002 W04-2326
The two annotators agreed on the annotations of 385/453 turns, achieving 84.99% agreement, with Kappa = 0.68.2 This inter-annotator agreement exceeds that of prior studies of emotion annotation in naturally occurring speech 2a3a5a4a7a6a8a6a9a4a11a10a13a12a15a14a17a16a19a18a21a20a22a12a23a14a25a24a26a18 a27 a20a22a12a23a14a25a24a26a18 (Carletta, 1996).
J96-2004
These features were motivated by the use of turn position as a feature for emotion prediction in (Ang et al., 2002), and the fact that measures of dialogue interactivity have been shown to correlate with learning gains in tutoring (Core et al., 2003).
E03-1072
As a result of this mismatch, recent work motivated by spoken dialogue applications has started to use naturally-occurring speech to train emotion predictors (Litman et al., 2001; Lee et al., 2001; Ang et al., 2002; Lee et al., 2002; Batliner et al., 2003; Devillers et al., 2003; Shafran et al., 2003), but often predicts emotions using only acoustic-prosodic features that would be automatically available to a dialogue system in real-time.
P01-1048
