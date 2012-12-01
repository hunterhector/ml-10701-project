(See Li and Li 2002 for details).
P02-1044
The word sense disambiguation method proposed in Yarowsky (1995) can also be viewed as a kind of co-training.
P95-1026
Li and Li (2002) proposed an algorithm for word sense disambiguation in translation between two languages, which they called ‘bilingual bootstrapping’.
P02-1044
Dasgupta et al (2001) and Abney (2002) conducted theoretical analyses on the performance (generalization error) of co-training.
P02-1046
Li, 2002.
P02-1044
Proof: According to (Abney, 2002), view independence implies classifier independence: )|(),|( )|(),|( 212 121 yYvhPuhyYvhP yYuhPvhyYuhP ====== ====== We can rewrite them as )|()|()|,,( 2121 yYvhPyYuhPyYvhuhP ======== Thus, we have )|})(|({)|},)(|({ )|},)(,)(|({ 21 21 yYxxhxPyYxxhxP yYxxhxhxP =˛=^=˛=^= =˛=^=^   It means ˛"= yr yhh,0.1 21  Theorem 2 indicates that in co-training with view independence, the CUCC values ( ˛"yr yhh, 21 ) are small, since by definition ¥<< yhhr 21 0 . According to Theorem 1, it is easy to reduce the uncertainties of the classifiers.
P02-1046
Bilingual Bootstrapping We also used the same data in (Li and Li, 2002) to conduct bilingual bootstrapping and word sense disambiguation.
P02-1044
D. Yarowsky, 1995.
P95-1026
Abney, 2002.
P02-1046
It includes co-training (Blum and Mitchell, 1998; Collins and Singer, 1998; Nigam and Ghani, 2000) and bilingual bootstrapping (Li and Li, 2002).
P02-1044
For other work on co-training, see (Muslea et al 200; Pierce and Cardie 2001).
W01-0501
Abney (2002) refined Dasgupta et al’s result by relaxing the view independence assumption with a new constraint.
P02-1046
