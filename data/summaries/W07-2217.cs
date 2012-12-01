As a comparison, Hall et al.(2006) reports 1.5 hours for training the partitioned SVM model and 10 minutes for parsing the evaluation set on the same Penn Treebank data.
P06-2041
(Attardi, 2006)) have been introduced for handling non-projective dependency trees: i.e., trees that cannot be drawn in the plane without crossing edges.
W06-2922
This approach has been used also for dependency parsing, generating spanning trees as candidates and computing the maximum spanning tree (MST) using discriminative learning algorithms (McDonald et al., 2005).
H05-1066
Nivre (2004) investigated the issue of (strict) incrementality for this type of parsers; i.e., if at any point of the analysis the processed input forms one connected structure.
C04-1010 W04-0308
Yih. 2005.
W05-0639
Rather, Yamada and Matsumoto (see also (Hall et al., 2006)) partition the training data in different sets, on the basis of Partof-Speech, then train one dual SVM model per set.
P06-2041
We briefly describe the tagger (see (Ciaramita & Altun, 2006) for more details), a Hidden Markov Model trained with the perceptron algorithm introduced in (Collins, 2002).
W02-1001 W06-1670
Dependency trees capture grammatical structures that can be useful in several language processing tasks such as information extraction (Culotta & Sorensen, 2004) and machine translation (Ding & Palmer, 2005).
P04-1054 P05-1067
Algorithm 2: Average multiclass perceptron input :S= (xi,yi)N;α0k =vector0, ∀k∈Y for t = 1 to T do choose j Et ={r∈Y :〈xj,αtr〉≥〈xj,αtyj〉} if|Et|> 0 then αt+1r = αtr− xj|Et|, ∀r∈Et αt+1yj = αtyj +xj output: αk = 1T summationtextt αtk, ∀k∈Y 3.4 Higher-order feature spaces Yamada and Matsumoto (2003) and McDonald and Pereira (2006) have shown that higher-order feature representations and modeling can improve parsing accuracy, although at significant computational costs.
E06-1011
For non-projective languages the algorithm is NP-hard and McDonald and Pereira (2006) introduce an approximate algorithm to handle such cases.
E06-1011
The final average model can be computed efficiently during training without storing the individualαvectors(e.g.,see(Ciaramita&Johnson, 2003)).
W03-1022
M.CiaramitaandY.Altun. 2006.
W06-1670
Nivre and Scholz (2004) proposed a variant of the model of Yamada and Matsumoto that reduces the complexity, from the worst case quadratic to linear.
C04-1010 W04-0308
shift-reduce parser We build upon DeSR, the shift-reduce parser described in (Attardi, 2006).
W06-2922
McDonald. 2006.
E06-1011
Approaches to dependency parsing either generate such trees by considering all possible spanning trees (McDonald et al., 2005), or build a single tree by means of shift-reduce parsing actions (Yamada & Matsumoto, 2003).
H05-1066
Dependency treebanks are becoming available in many languages, and several approaches to dependency parsing on multiple languages have been evaluated in the CoNLL 2006 and 2007 shared tasks (Buchholz & Marsi, 2006; Nivre et al., 2007).
D07-1096 W06-2920
We notice in particular that, given the lack of nonprojective cases/rules, theparser ofHall et al.(2006) is almost identical to our parser, hence the difference in accuracy (+1.1%) might effectively be due to a better classifier.
P06-2041
To regularize the model we take as the final model the average of all weight vectors posited during training (Collins, 2002).
W02-1001
Koo. 2005.
H05-1064
Overall the accuracy of the DeSR parser with semantic information is slightly inferior to that of the second-order MST parser (McDonald & Pereira, 2006) (91.5% UAS).
E06-1011
McDonald and Pereira (2006) have shown that incorporating second order features relating to adjacent edge pairs improves the accuracy of maximum spanning tree parsers (MST).
E06-1011
Semantic features could be also easily included in other types of dependency parsing algorithms, e.g., MST, and in current methods for constituent parse reranking (Collins, 2000; Charniak & Johnson, 2005).
P05-1022
This and Nivre and Scholz’s (2004) provide among the simplest and most efficient methods.
C04-1010 W04-0308
Attardi (2006) proposed a variant of the rules that handle non-projective relations while parsing deterministicallyinasinglepass.
W06-2922
Collins and Koo (Collins & Koo, 2005) introduced an improved reranking model for parsing which includes a hidden layer of semantic features.
H05-1064
Yi and Palmer (2005) retrained a constituent parser in which phrases were annotated with argument information to improve SRL, however this didn’t improve over the output of the basic parser.
W05-0639
Syntactic parsing can provide useful features for these tasks; e.g., Punyakanok et al.(2005) show that full parsing is effective for semantic role labeling (see also related approaches evaluated within the CoNNL 2005 shared task (Carreras et al., 2005)).
W05-0620
Attardi. 2006.
W06-2922
Deterministic dependency parsers which run in linear time have also been developed (Nivre & Scholz, 2004; Attardi, 2006).
C04-1010 W04-0308 W06-2922
Also the MST parser of McDonald uses a variant of the perceptron algorithm (McDonald, 2006).
E06-1011
MIRA (Crammer & Singer, 2003)) could provide further gains in accuracy, as shown with the MST parser (McDonald et al., 2005).
H05-1066
The best result on this dataset to date (92.7% UAS) is that of Sagae and Lavie (Sagae & Lavie, 2006) who use a parser which combines the predictions of several pre-existing parsers, including McDonald’s and Nivre’s parsers.
N06-2033
Our base model’s accuracy (90.55% UAS) compares well with the accuracy of the parsers based on the polynomial kernel trained with SVM of Yamada and Matsumoto (UAS 90.3%), and Hall et al.(2006) (UAS 89.4%).
P06-2041
Thechoiceismotivatedbythesimplicity and performance of perceptrons, which have proved competitive on a number of tasks; e.g., in shallow parsing, where perceptron’s performance is comparable to that of Conditional Random Field models (Sha & Pereira, 2003).
N03-1028
experiments 5.1 Data and setup We used the standard partitions of the Wall Street Journal Penn Treebank (Marcus et al., 1993); i.e., sections 2-21 for training, section 22 for development and section 23 for evaluation.
J93-2004
The perceptron has been used in previous work on dependency parsing by Carreras et al.(2006), with a parser based on Eisner’s algorithm (Eisner, 2000), and also on incremental constituent parsing (Collins & Roark, 2006).
W06-2925
