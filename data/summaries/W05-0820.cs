The focus of the task was to build a probabilistic phrase translation table, since most of the other resources were provided — for more on phrase-based statistical machine translation, refer to Koehn et al.(2003). The participants’ systems were compared by how well they translated 2000 previously unseen test sentences from the same domain.
E03-1076 N03-1017
The field of statistical machine translation has been blessed with a long tradition of freely available software tools — such as GIZA++ (Och and Ney, 2003) — and parallel corpora — such as the Canadian Hansards2.
J03-1002 P03-1021
However, the field is moving fast, and a number of steps help to improve upon the provided baseline setup, e.g., larger language models trained on general text (up to a billion words have been used), better reodering models (e.g., suggested by Tillman (2004) and Och et al.(2004)), better language-specific preprocessing (Koehn and Knight, 2003) and restructuring (Collins et al., 2005), additional feature functions such as word class language models, and minimum error rate training (Och, 2003) to optimize parameters.
E03-1076 J03-1002 N03-1017 N04-1021 P03-1021 P05-1066
Translation performance was measured using the BLEU score (Papineni et al., 2002), which measures n-gram overlap with a reference translation.
P02-1040
In addition, we also made a word alignment available, which was derived using a variant of the current default method for word alignment – Och and Ney (2003)’s refined method.
J03-1002 P03-1021
