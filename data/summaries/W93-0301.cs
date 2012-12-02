The method was intended as a replacement for sentence-based methods (e.g., (Brown et al., 1991a; Gale and Church, 1991b; Kay and Rosenschein, 1993)), which are very sensitive to noise.
H91-1026 J93-1006 J93-2003 P91-1022 P91-1023 P91-1034 P93-1001
char_align's output), (2) reduce the number of parameters that need to be estimated, and (3) prepare the ground for the second step, the search for the best alignment (described in section 2.2). 2.1.1 Brown et al.'s Model In the context of their statistical machine translation project (Brown et al., 1990), Brown et al.estimate Pr(f\[e), the probability that f, a sentence in one language (say French), is the translation of e, a sentence in the other language (say English).
J90-2002
Compared with other word alignment algorithms (Brown et al., 1993; Gale and Church, 1991a), word_align does not require sentence alignment as input, and was shown to produce useful alignments for small and noisy corpora.
H91-1026 J93-2003 P91-1022 P91-1023 P91-1034
Aligning parallel texts has recently received considerable attention (Warwick et al., 1990; Brown et al., 1991a; Gale and Church, 1991b; Gale and Church, 1991a; Kay and Rosenschein, 1993; Simard et al., 1992; Church, 1993; Kupiec, 1993; Matsumoto et al., 1993).
H91-1026 J93-1006 J93-2003 P91-1022 P91-1023 P91-1034 P93-1001 P93-1003 P93-1004
These methods have been used in machine translation (Brown et al., 1990; Sadler, 1989), terminology research and translation aids (Isabelle, 1992; Ogden and Gonzales, 1993), bilingual lexicography (Klavans and Tzoukermann, 1990), collocation studies (Smadja, 1992), word-sense disambiguation (Brown et al., 1991b; Gale et al., 1992) and information retrieval in a multilingual environment (Landauer and Littman, 1990).
J90-2002 P91-1022 P91-1034
To deal with these robustness issues, Church (1993) developed a character-based alignment method called char_align.
P93-1001
Church. 1993.
P93-1001
A similar dynamic programming approach was used by Gale and Church for word alignment (Gale and Church, 1991a), to handle dependency between connections.
H91-1026 P91-1023
alignment Algorithm 2.1 Estimation of translation probabilities The translation probabilities are estimated using a method based on Brown et al.'s Model 2 (1993), which is summarized in the following subsection, 2.1.1.
J93-2003
The program takes the output of char_align (Church, 1993), a robust alternative to sentence-based alignment programs, and applies word-level constraints using a version of Brown el al.'s Model 2 (Brown et al., 1993), modified and extended to deal with robustness issues.
J93-2003 P93-1001
