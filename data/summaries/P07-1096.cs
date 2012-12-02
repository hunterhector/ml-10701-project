In (Collins and Roark, 2004; Shen and Joshi, 2005), a search stops if there is no hypothesis compatible with the gold standard in the queue of candidates.
H05-1102 P04-1015
Our system reports an error rate of 2.67% on the standard PTB test set, a relative 3.3% error reduction of the previous best system (Toutanova et al., 2003) by using fewer features.
N03-1033
We use a bidirectional search strategy (Woods, 1976; Satta and Stock, 1994), and our algorithm is based on Perceptron learning (Collins, 2002).
W02-1001
By using deterministic search, it obtains an error rate of 2.73%, a 5.9% relative error reduction 760 over the previous best deterministic algorithm (Tsuruoka and Tsujii, 2005).
H05-1059
We proposed a Perceptron like learning algorithm (Collins and Roark, 2004; Daum´e III and Marcu, 2005) for guided learning.
P04-1015
In (Daum´e III and Marcu, 2005), as well as other similar works (Collins, 2002; Collins and Roark, 2004; Shen and Joshi, 2005), only left-toright search was employed.
H05-1102 P04-1015 W02-1001
Following (Ratnaparkhi, 1996; Collins, 2002; Toutanova et al., 2003; Tsuruoka and Tsujii, 2005), 765 Feature Sets Templates Error% A Ratnaparkhi’s 3.05 B A + [t0,t1],[t0,t−1,t1],[t0,t1,t2] 2.92 C B + [t0,t−2],[t0,t2],[t0,t−2,w0],[t0,t−1,w0],[t0,t1,w0], [t0,t2,w0], [t0,t−2,t−1,w0],[t0,t−1,t1,w0],[t0,t1,t2,w0] 2.84 D C + [t0,w−1,w0],[t0,w1,w0] 2.78 E D + [t0,X = prefix or suffix of w0],4 < |X| ≤ 9 2.72 Table 2: Experiments on the development data with beam width of 3 we cut the PTB into the training, development and test sets as shown in Table 1.
H05-1059 N03-1033 W02-1001
Tsuruoka and Tsujii (2005) proposed the easiest-first approach which greatly reduced the computation complexity of inference while maintaining the accuracy on labeling.
H05-1059
In our experiments, we have used Averaged Perceptron (Collins, 2002; Freund and Schapire, 1999) and Perceptron with margin (Krauth and M´ezard, 1987) to improve performance.
W02-1001
Toutanova et al.(2003) reported a POS tagger based on cyclic dependency network.
N03-1033
It is reported in (Toutanova et al., 2003) that a crude company name detector was used to generate features, and it gave rise to significant improvement in performance.
N03-1033
By using deterministic search, it obtains an error rate of 2.73%, a 5.9% relative error reduction over the previous best deterministic algorithm (Tsuruoka and Tsujii, 2005).
H05-1059
It obtains an error rate of 2.67% on the standard PTB test set, which represents 3.3% relative error reduction over the previous best result (Toutanova et al., 2003) on the same data set, while using fewer features.
N03-1033
Collins (2002) proposed a Perceptron like learning algorithm to solve sequence classification in the traditional left-to-right order.
W02-1001
Compared to previous best result on the same data set, 2.76% by (Toutanova et al., 2003), our best result shows a relative error reduction of 3.3%.
N03-1033
The new POS tagger is similar to (Toutanova et al., 2003; Tsuruoka and Tsujii, 2005) in the way that we employ context features.
H05-1059 N03-1033
766 System Beam Error% (Ratnaparkhi, 1996) 5 3.37 (Tsuruoka and Tsujii, 2005) 1 2.90 (Collins, 2002) 2.89 Guided Learning, feature B 3 2.85 (Tsuruoka and Tsujii, 2005) all 2.85 (Gim´enez and M`arquez, 2004) 2.84 (Toutanova et al., 2003) 2.76 Guided Learning, feature E 1 2.73 Guided Learning, feature E 3 2.67 Table 4: Comparison with the previous works According to the experiments shown above, we build our best system by using feature set E with beam width B = 3.
H05-1059 N03-1033 W02-1001
Works Tsuruoka and Tsujii (2005) proposed a bidirectional POS tagger, in which the order of inference is handled with the easiest-first heuristic.
H05-1059
Following (Collins, 2002), we do not distinguish rare words.
W02-1001
With set E, we use prefixes and suffixes of length up to 9, as in (Toutanova et al., 2003; Tsuruoka and Tsujii, 2005).
H05-1059 N03-1033
