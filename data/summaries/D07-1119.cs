Ciaramita. 2007.
W07-2217
We then used a parsing revision technique (Attardi and Ciaramita, 2007) to learn how to correct these errors, producing a parse reviser called DesrReviser.
N07-1049 W07-2217
Classifier-based dependency parsers (Yamada and Matsumoto, 2003; Nivre and Scholz, 2004) learn from an annotated corpus how to select an appropriate sequence of Shift/Reduce actions to construct the dependency tree for a sentence.
C04-1010 W04-2407
Attardi. 2007.
N07-1049
Attardi and Ciaramita (2007) showed that 80% of the corrections can be typically dealt with just 20 tree revision rules.
N07-1049 W07-2217
4 Non-Projective Relations For handling non-projective relations, Nivre and Nilsson (2005) suggested applying a preprocessing step to a dependency parser, which consists in lifting non-projective arcs to their head repeatedly, until the tree becomes pseudo-projective.
P05-1013
R. McDonald, et al.2005. Non-projective Dependency Parsing using Spanning Tree Algorithms.
H05-1066
Acknowledgments. The following treebanks were used for training the parser: (Aduriz et al., 2003; Böhmovà et al., 2003; Chen et al., 2003; Hajiç et al., 2004; Marcus et al., 1993; Martí et al., 2002; Montemagni et al.2003; Oflazer et al., 2003; Prokopidis et al., 2005; Csendes et al., 2005).
J93-2004
For the second adaptation task we were given a large collection of unlabeled data in the chemistry domain (Kulick et al, 2004) as well as a test set of 5000 tokens (200 sentences) to parse (english_pchemtbtb_test.conll).
W04-3111
In DeSR non-projective dependencies are handled in a single step by means of the following additional parsing rules, slightly different from those in (Attardi, 2006): 〈s1|s2|S, n|I, T, A〉 Right2 d 〈 S, s 1|n|I, T, A∪{(s2, d, n)}〉 〈s1|s2|S, n|I, T, A〉 Left2 d 〈s 2|S, s1|I, T, A∪{(n, d, s2)}〉 〈s1|s2|s3|S, n|I, T, A〉 Right3 d 〈 S, s 1|s2|n|I, T, A∪{(s3, d, n)}〉 〈s1|s2|s3|S, n|I, T, A〉 Left3 d 〈s 2|s3|S, s1|I, T, A∪{(n, d, s3)}〉 〈s1|s2|S, n|I, T, A〉 Extract 〈n|s1|S, I, s2|T, A〉 〈S, I, s1|T, A〉 Insert 〈s1|S, I, T, A〉 Left2, Right2 are similar to Left and Right, except that they create links crossing one intermediate node, while Left3 and Right3 cross two intermediate nodes.
W06-2922
Nivre, et al.2004. Memory-based Dependency Parsing.
C04-1010 W04-2407
More details on such aspects of the DeSR parser can be found in (Ciaramita and Attardi 2007).
N07-1049 W07-2217
Classifier-based Parsing DeSR (Attardi, 2006) is an incremental deterministic classifier-based parser.
W06-2922
