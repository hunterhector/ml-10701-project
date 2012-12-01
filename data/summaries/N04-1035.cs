The fundamental assumption underlying much recent work in statistical machine translation (Yamada and Knight, 2001; Eisner, 2003; Gildea, 2003) is that local transformations (primarily child-node re-orderings) of one-level parent-children substructures are an adequate model for parallel corpora.
P01-1067 P03-1011 P03-2041
In addition to being motivated by rule-based systems, we also see advantages to English syntax within the statistical framework, such as marrying syntax-based translation models with syntaxbased language models (Charniak et al., 2003) and other potential benefits described by Eisner (2003).
P03-2041
In a very interesting study of syntax in statistical machine translation, Fox (2002) looks at how well proposed translation models fit actual translation data.
W02-1039
Along this line, (Koehn et al., 2003) present convincing evidence that restricting phrasal translation to syntactic constituents yields poor translation performance – the ability to translate nonconstituent phrases (such as “there are”, “note that”, and “according to”) turns out to be critical and pervasive.
N03-1017
Fox (2002) identified three major causes of crossings between English and French: the “ne ...
W02-1039
We also chose French to compare our study with that of Fox (2002).
W02-1039
Previous to Fox (2002), it had been observed that this model would prohibit certain re-orderings in certain language pairs (such as subjectVP(verb-object) into verb-subject-object), but Fox carried out the first careful empirical study, showing that many other common translation patterns fall outside the scope of the child-reordering model.
W02-1039
Note that this definition is similar to, but not quite the same as, the definition of a span given by Fox (2002).
W02-1039
For the Hansard corpus, we took the human annotation of word alignment described in (Och and Ney, 2000).
P00-1056
For the FBIS corpus (representing eight million English words), we automatically generated word-alignments using GIZA++ (Och and Ney, 2003), which we trained on a much larger data set (150 million words).
J03-1002
The x-axis represents different restrictions on the size of these rules: if we use a model that restrict rules to a single expansion of a non-terminal into a sequence of symbols, we are in the scope of the child-reordering model of (Yamada and Knight, 2001; Fox, 2002).
P01-1067 W02-1039
One approach here is that of Wu (1997), in which word-movement is modeled by rotations at unlabeled, binary-branching nodes.
J97-3002
The search for these rules is driven exactly by the problems raised by Fox (2002) – cases of crossing and divergence motivate the algorithms to come up with better explanations of the data and better rules.
W02-1039
For this reason, we think it is important to learn from the model/data explainability studies of Fox (2002) and to extend her results.
W02-1039
