We used the selective gain computation (SGC) algorithm (Zhou et al., 2003) to select features and estimate parameters for its fast performance.
W03-1020
For example, Hirschman et al.(1999) have augmented the BOW approach with stemming, NE recognition, NE ltering, semantic class identi cation and pronoun resolution to achieve 36% HumSent1 accuracy in the Remedia test set.
P99-1042
Charniak et al.(2000) used additional strategies for different question types to achieve 41%.
W00-0601
5Refer to the readme le of MINIPAR downloaded from http://www.cs.ualberta.ca/ lindek/minipar.htm 5 Experimental Results We selected the features used in Quarc (Riloff and Thelen, 2000) to establish the reference performance level.
W00-0603
(1) Let x be the question (Q) and y be the answer sentence Ci that answers x. Equation 1 can be computed by the ME method (Zhou et al., 2003): p(y|x) = 1Z(x) exp summationtext j λjfj(x,y), (2) where Z(x) = summationtexty exp summationtext j λjfj(x,y) is a normalization factor, fj(x,y) is the indicator function for feature fj; fj occurs in the context x, λj is the weight of fj.
W03-1020
Based on these technologies, Riloff and Thelen (2000) improved the HumSent accuracy to 40% by applying a set of heuristic rules that assign handcrafted weights to matching words and NE.
W00-0603
The state-of-art performance reached 42% with answer patterns derived from web (Du et al., 2005).
H05-1076
We set up our experiments such that the linguistic features are applied incrementally (i) First, we use only POS tags of matching words among questions 6The features in (Charniak et al., 2000) and (Du et al., 2005) could have been included similarly if they were available.
H05-1076 W00-0601
We used the Remedia corpus (Hirschman et al., 1999) and ChungHwa corpus (Xu and Meng, 2005) in our experiments.
P99-1042
