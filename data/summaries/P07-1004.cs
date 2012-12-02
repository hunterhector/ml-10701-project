For details, see (Ueffing and Ney, 2007).
W07-0724
Yarowsky. 1995.
P95-1026
Along similar lines, (Fraser and Marcu, 2006) combine a generative model of word alignment with a log-linear discriminative model trained on a small set of hand aligned sentences.
P06-1097
These lists are rescored with the following models: (a) the different models used in the decoder which are described above, (b) two different features based on IBM Model 1 (Brown et al., 1993), (c) posterior probabilities for words, phrases, n-grams, and sentence length (Zens and Ney, 2006; Ueffing and Ney, 2007), all calculated over the Nbest list and using the sentence probabilities which the baseline system assigns to the translation hypotheses.
J93-2003 W06-3110 W07-0724
Abney. 2004.
J04-3004
Under certain precise conditions, as described in (Abney, 2004), we can analyze Algorithm 1 as minimizing the entropy of the distribution over translations of U.
J04-3004
We provide a basic description here; for a detailed description see (Ueffing et al., 2007).
W07-0724
BLEU score using the algorithm described in (Och, 2003).
P03-1021
Framework 3.1 The Algorithm Our transductive learning algorithm, Algorithm 1, is inspired by the Yarowsky algorithm (Yarowsky, 1995; Abney, 2004).
J04-3004 P95-1026
Evaluation Metrics We evaluated the generated translations using three different evaluation metrics: BLEU score (Papineni et al., 2002), mWER (multi-reference word error rate), and mPER (multi-reference positionindependent word error rate) (Nießen et al., 2000).
P02-1040
We used the following scoring functions in our experiments: Length-normalized Score: Each translated sentence pair (t,s) is scored according to the model probability p(t|s) normalized by the length|t|of the target sentence: Score(t,s) = p(t|s) 1|t| (3) Confidence Estimation: The confidence estimation which we implemented follows the approaches suggested in (Blatz et al., 2003; Ueffing and Ney, 2007): The confidence score of a target sentence t is calculated as a log-linear combination of phrase posterior probabilities, Levenshtein-based word posterior probabilities, and a target language model score.
W07-0724
