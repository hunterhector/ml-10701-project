Wu and Jiang’s (2000) model provides a good complement for the two, because it achieves a higher recall than the rule-based model and a higher precision than the trigram model for disyllabic words.
W00-1207
ˆP(t3) = f(t3)/N (1) ˆP(t3|t2) = f(t2,t3)/f(t2) (2) ˆP(t3|t1,t2) = f(t1,t2,t3)/f(t1,t2) (3) P(t3|t1,t2) = λ1 ˆP(t3)+ λ2 ˆP(t3|t2)+ λ3 ˆP(t3|t1,t2) (4) As in Brants (2000), λ1 + λ2 + λ3 = 1, and the values of λ1, λ2, and λ3 are estimated by deleted interpolation, following Brants’ algorithm for calculating the weights for context-independent linear interpolation when the n-gram frequencies are known.
A00-1031
Wu and Jiang’s (2000) model complements the other two, as it achieves a higher recall than the rule-based model and a higher precision than the trigram model for disyllabic words.
W00-1207
It will also be relevant to apply advanced statistical models that can incorporate various useful information to this task, e.g., the maximum entropy model (Ratnaparkhi, 1996).
W96-0213
Wu and Jiang (2000) calculated P(Cat,Pos,Len) for each character, where Cat is the POS of a word containing the character, Pos is the position of the character in that word, and Len is the length of that word.
W00-1207
The few existing studies all attempted to develop a unified statistical model to compute the probability of a word having a particular POS category for all Chinese unknown words (Chen et al., 1997; Wu and Jiang, 2000; Goh, 2003).
W00-1207
Second, Wu and Jiang (2000) argued that assigning POS to Chinese unknown words on the basis of the internal structure of those words will “result in massive overgeneration” (p.
W00-1207
Following Brants (2000), we first calculate the maximum likelihood probabilities ˆP for unigrams, bigrams, and trigrams as in (1-3).
A00-1031
The models we will consider are a rule-based model, the trigram model, and the statistical model developed by Wu and Jiang (2000).
W00-1207
The rule-based approach was rejected with the claim that rules are bound to overgenerate (Wu and Jiang, 2000).
W00-1207
Chars Data R P F 2 Training 24.05 96.94 38.54 Test 27.66 96.89 43.03 3 Training 93.50 99.83 96.56 Test 93.72 99.86 96.69 4 Training 98.70 99.02 98.86 Test 99.20 99.20 99.20 5+ Training 99.86 100 99.93 Test 100 100 100 Total Training 70.60 99.40 82.56 Test 69.72 99.34 81.94 Table 4: Results for the rule-based model Guesses 1-Best 2-Best 3-Best Training 62.01 93.63 96.21 Test 62.96 92.64 94.30 Table 5: Results for the trigram model Chars Data R P F 2 Training 65.19 75.57 67.00 Test 63.82 77.92 70.17 3 Training 59.50 98.41 74.16 Test 55.63 99.07 71.25 Table 6: Results for Wu and Jiang’s (2000) model 5.3 Results for the Combined Model To evaluate the combined model, we first define the upper bound of the precision for the model as the number of unknown words tagged correctly by at least one of the three models divided by the total number of unknown words.
W00-1207
