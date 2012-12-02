Multi-lingual Name Tagger Our baseline name tagger is based on an HMM that generally follows the Nymble model (Bikel et al, 1997).
A97-1029
Section 2 briefly describes the efforts made by previous researchers to use semi-supervised learning as well as the work of (Banko and Brill, 2001).
P01-1005
Banko and Brill (2001) suggested that the development of very large training corpora may be most effective for progress in empirical natural language processing.
P01-1005
For the specific task of named entity annotation, some researchers have emphasized the creation of taggers from minimal seed sets (Strzalkowski and Wang, 1996; Collins and Singer, 1999; Lin et al., 2003) while another line of inquiry (which we are pursuing) has sought to improve on high-performance baseline taggers (Miller et al., 2004).
C96-2157 N04-1043 W99-0613
Curran. 2002.
P02-1030 W02-1029 W02-2008
We divided the large unlabeled corpus into segments based on news sources and dates in order to: 1) create segments of manageable size; 2) separately evaluate the contribution of each segment (using a labeled development test set) and reject those which do not help; and 3) apply the latest updated best model to each subsequent 1 We have also used this metric in the context of rescoring of name hypotheses (Ji and Grishman, 2005); Scheffer et al.(2001) used a similar metric for active learning of name tags.
P05-1051
However, (Curran, 2002) and (Curran and Osborne, 2002) claimed that the choice of statistical model is more important than relying upon large corpora.
P02-1030 W02-1029 W02-2008
Recent work has replicated their work on thesaurus extraction (Curran and Moens, 2002) and is-a relation extraction (Ravichandran et al., 2004), showing that collecting data over a very large corpus significantly improves system performance.
P02-1030 W02-1029 W02-2008
Therefore, in contrast to the claim in (Banko and Brill, 2001), we concluded that, for some applications, effective use of large unlabeled corpora demands good data selection measures.
P01-1005
It has shown promise in improving the performance of many tasks such as name tagging (Miller et al., 2004), semantic class extraction (Lin et al., 2003), chunking (Ando and Zhang, 2005), coreference resolution (Bean and Riloff, 2004) and text classification (Blum and Mitchell, 1998).
N04-1038 N04-1043 P05-1001
Banko and Brill (2001) suggested that the development of very large training corpora may be central to progress in empirical natural language processing.
P01-1005
Work This work presented here extends a substantial body of previous work (Blum and Mitchell, 1998; Riloff and Jones, 1999; Ando and Zhang, 2005) 48 that all focus on reducing annotation requirements.
P05-1001
