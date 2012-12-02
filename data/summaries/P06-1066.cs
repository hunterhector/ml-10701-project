Under the MaxEnt model, we have Ω = pθ(o|A1,A2) = exp( summationtext i θihi(o,A1,A2))summationtext o exp( summationtext i θihi(o,A1,A2))(10) where the functions hi ∈{0,1}are model features and the θi are weights of the model features which can be trained by different algorithms (Malouf, 2002).
W02-2018
However, at the phrase level, reordering is still a computationally expensive problem just like reordering at the word level (Knight, 1999).
J99-4005
Another simple model is flat reordering model (Wu, 1996; Zens et al., 2004; Kumar et al., 2005) which is not content dependent either.
C04-1030 H05-1021 P96-1021
From this point, our decoder is similar to the work by Chiang (2005).
P05-1033
Fox. 2002.
W02-1039
Another smart reordering model was proposed by Chiang (2005).
P05-1033
These features are very common in state-of-the-art systems (Koehn et al., 2005; Chiang, 2005) and λs are weights of features.
P05-1033
In the following, we will define the model in a straight way, not in the dynamic programming recursion way used by (Wu, 1996; Zens et al., 2004).
C04-1030 P96-1021
Following the Bracketing Transduction Grammar (BTG) (Wu, 1996), we built a CKY-style decoder for our system, which makes it possible to reorder phrases hierarchically.
P96-1021
One of assumptions of phrase-based SMT is that phrase cohere across two languages (Fox, 2002), which means phrases in one language tend to be moved together during translation.
W02-1039
Here, under the ITG constraint (Wu, 1997; Zens et al., 2004), we need to consider just two kinds of reorderings, straight and inverted between two consecutive blocks.
C04-1030 J97-3002
Given an input sentence c, the final translation e∗ is derived from the best derivation D∗ D∗ = argmax c(D)=c Pr(D) e∗ = e(D∗) (8) 2.2 Decoder We developed a CKY style decoder that employs a beam search algorithm, similar to the one by Chiang (2005).
P05-1033
The k-best list is very important for the minimum error rate training (Och, 2003a) which is used for tuning the weights λ for our model.
P03-1021
One is distortion model (Och and Ney, 2004; Koehn et al., 2003) which penalizes translations according to their jump distance instead of their content.
J04-4002 N03-1017 P03-1021
Line 4 and 5 are similar to the phrase extraction algorithm by Och (2003b).
P03-1021
We use a very lazy algorithm for the k-best list generation, which runs two phases similarly to the one by Huang et al.(2005). In the first phase, the decoder runs as usual except that it keeps some information of weaker derivations which are to be discarded during recombination.
W05-1506
In view of content-independency of the distortion and flat reordering models, several researchers (Och et al., 2004; Tillmann, 2004; Kumar et al., 2005; Koehn et al., 2005) proposed a more powerful model called lexicalized reordering model that is phrase dependent.
H05-1021 J04-4002 N04-4026 P05-1069
