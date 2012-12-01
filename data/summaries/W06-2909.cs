66 (Punyakanok et al., 2005; Toutanova et al., 2005; Pradhan et al., 2005b) were obtained by exploiting the information on the whole predicate argument structure.
P05-1072 P05-1073
Recent work on Semantic Role Labeling (SRL) (Carreras and M`arquez, 2005) has shown that to achieve high labeling accuracy a joint inference on the whole predicate argument structure should be applied.
W05-0620
The re-ranking approach is the most promising one as suggested in (Toutanova et al., 2005) but it does not clearly reveal if tree kernels can be used to learn the difference between correct or incorrect argument structures.
P05-1073
In (Toutanova et al., 2005), it was observed that there are strong dependencies among the labels of the semantic argument nodes of a verb.
P05-1073
We adopt the same algorithm described in (Toutanova et al., 2005).
P05-1073
Accordingly, our basic system is similar to the one proposed in (Pradhan et al., 2005a) and it is hereby described.
P05-1072
(Gildea and Jurasfky, 2002; Pradhan et al., 2005a).
J02-3001 P05-1072
For example, to detect the interesting context, the modeling of syntax/semantics-based features should take into account linguistic aspects like ancestor nodes or semantic dependencies (Toutanova et al., 2004).
W04-3222
As described in (Collins and Duffy, 2002), ∆ can be computed in O(|Nt1|×|Nt2|).
P02-1034
We use the approach adopted in (Shen et al., 2003), which generates all possible pairs from the m examples, i.e. parenleftbigm2parenrightbig pairs.
W03-1012
experiments The experiments were carried out within the setting defined in the CoNLL-2005 Shared Task (Carreras and M`arquez, 2005).
W05-0620
We used the models developed during our participation to the CoNLL 2005 shared task (Moschitti et al., 2005).
W05-0630
Regarding the design of features for predicateargument pairs, we can use the attribute-values defined in (Gildea and Jurasfky, 2002) or tree structures (Moschitti, 2004).
J02-3001 P04-1043
We achieved 80.68% which is practically equal to the result obtained in (Punyakanok et al., 2005; Carreras and M`arquez, 2005) for core roles, i.e. 81%.
W05-0620
The usual approach (Toutanova et al., 2005) uses a traditional boundary classifier (TBC) to select the set of potential argument nodes.
P05-1073
For the AST-based classifiers we used a λ equal to 0.4 (see (Moschitti, 2004)).
P04-1043
A viable approach to generate a large number of features has been proposed in (Collins and Duffy, 2002), where convolution kernels were used to implicitly define a tree substructure space.
P02-1034
3.3 Re-ranking NSTs with Tree Kernels To implement the re-ranking model, we follow the approach described in (Toutanova et al., 2005).
P05-1073
The time needed for tree kernel function was not so problematic as we could use the fast evaluation proposed in (Moschitti, 2006).
E06-1015
Third, the comparison with the CoNLL 2005 results (Carreras and M`arquez, 2005) can only be carried out with respect to the whole SRL task (bnd+class in table 2) since boundary detection versus role classification is generally not provided in CoNLL 2005.
W05-0620
Such outcome is slightly higher than our official CoNLL result (Moschitti et al., 2005) obtained without converting SVM scores into probabilities.
W05-0630
These include the features for each arguments (Gildea and Jurasfky, 2002) and global features like the sequence of argument labels, e.g. 〈Arg0,Arg1,ArgM〉.
J02-3001
The tree kernel used in this article was proposed in (Collins and Duffy, 2002) for syntactic parsing re-ranking.
P02-1034
Moreover, we modeled SRL as a re-ranking task in line with (Toutanova et al., 2005).
P05-1073
In (Pradhan et al., 2005b), some experiments were conducted on SRL systems trained using different syntactic views.
P05-1072
(2) We can consider the classification probability provided by TBC and TRC (Pradhan et al., 2005a) and select the m most probable structures.
P05-1072
In this paper, we apply the traditional boundary (TBC) and role (TRC) classifiers (Pradhan et al., 2005a), which are based on binary predicate/argument relations, to label all parse tree nodes corresponding to potential arguments.
P05-1072
