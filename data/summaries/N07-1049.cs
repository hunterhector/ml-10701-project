This definition corresponds to applying the revisions to the original tree in a batch, as in (Brill, 1993).
P93-1035
Nivre and Scholz (2004) proposed a variant of the model of Yamada and Matsumoto that reduces the complexity from the worst case quadratic to linear.
C04-1010
In transformationbased learning (Brill, 1993; Brill, 1995; Satta & Brill, 1995) the learning algorithm starts with a baseline assignment, e.g., the most frequent Part-ofSpeech for a word, then repeatedly applies rewriting rules.
P93-1035
work Several authors have proposed to improve parsing via re-ranking (Collins, 2000; Charniak & Johnson, 2005; Collins & Koo, 2006).
P05-1022
A dependency parser is trained on a corpus annotated with lexical dependencies, which are easier to produce by annotators without deep linguistic knowledge and are becoming available in many languages (Buchholz & Marsi, 2006).
W06-2920
Attardi. 2006.
W06-2922
shift-reduce dependency parser As a base parser we use DeSR, a shift-reduce parser described in (Attardi, 2006).
W06-2922
The work of Hall and Novak (Hall & Novak, 2005) is the closest to ours.
W05-1505
Attardi (2006) proposed a variant of the rules that allows deterministic single-pass parsing and as well as handling non-projective relations.
W06-2922
parsing Detection of dependency relations can be useful in tasks such as information extraction (Culotta & Sorensen, 2004), lexical acquisition (Snow et al., 2005), ontology learning (Ciaramita et al., 2005), and machine translation (Ding & Palmer, 2005).
P04-1054 P05-1067
In particular, Nivre and Scholz (2004) and Attardi (2006) have developed deterministic dependency parsers with linear complexity, suitable for processing large amounts of text, as required, for example, in information retrieval applications.
C04-1010 W06-2922 W06-2933
This approachhasbeenusedalsofordependencyparsing, generating spanning trees as candidates and computing the maximum spanning tree using discriminative learning algorithms (McDonald et al., 2005).
H05-1066
The problem occurs most often on punctuations (66/84 on WSJ section 23), so it affects only marginally the accuracy scores (UAS, LAS) as computed in the CoNLL-X evaluation (Buchholz & Marsi, 2006).
W06-2920
Approaches to dependency parsing either generate such trees by considering all possible spanning trees (McDonald et al., 2005), or build a single tree on the fly by means of shift-reduce parsing actions (Yamada & Matsumoto, 2003).
H05-1066
For regularization purposes we adopt an average perceptron (Collins, 2002) which returns for each y, αy = 1T summationtextTt=1 αty, the average of all weight vectors αty posited during training.
W02-1001
TherevisionmodelofNakagawaetal.(2002) applies a second classifier for deciding whether the predictions of a base learner are accurate.
P02-1063
The table also reports the scores obtained on the same data set by by the shift reduce parsers of Nivre and Scholz’s (2004) and Yamada andMatsumoto(2003), andMcDonaldandPereira’s second-order maximum spanning tree parser (McDonald & Pereira, 2006).
C04-1010 E06-1011
Recent developments in dependency parsing show that deterministicparserscanachievegoodaccuracy(Nivre& Scholz, 2004), andhighperformance, intherangeof hundreds of sentences per second (Attardi, 2006).
C04-1010 W06-2922 W06-2933
Occasionally, in 59 sentences out of 2416 on section 23 of the Wall Street Journal Penn Treebank (Marcus et al., 1993), the shift-reduce parser fails to attach a node to a head, producing a disconnected graph.
J93-2004
Several approaches to dependency parsing on multiple languages have been evaluated in the CoNLL-X Shared Task (Buchholz & Marsi, 2006).
W06-2920
In comparison, the complexity of McDonald’s parser (2006) is cubic, while the parser of Yamada and Matsumoto (2003) has a worst case quadratic complexity.
E06-1011
The best system (Corston-Oliver & Aue, 2006), a variant of the MST algorithm, obtained 89.54 UAS, while the second system (Nivre, 2006) obtained 89.50; cf.
W06-2928 W06-2933
We investigate a novel revision approach to dependency parsing related to re-ranking and transformation-based methods (Brill, 1993; Brill, 1995; Collins, 2000; Charniak & Johnson, 2005; Collins & Koo, 2006).
P05-1022 P93-1035
