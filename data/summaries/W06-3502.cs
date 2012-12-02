This claim is consistent with observations of Carroll (1994) that parsing software optimisation techniques tend to be limited in their applicability to the individual grammars they were developed for.
P94-1040
To achieve parsing ef ciency, TRIPS uses a bestrst beam search algorithm based on the scores from a parse selection model (Dzikovska et al., 2005; Elsner et al., 2005).
W05-1525 W05-1526
Carroll. 1994.
P94-1040
Another option for speeding up parsing that we have not discussed in detail is using a typed grammar without disjunction and speeding up uni cation as done in HPSG grammars (Kiefer et al., 1999).
P99-1061
Lexical semantic features are known to be helpful in both deep (Tetreault, 2005) and shallow interpretation tasks (Narayanan and Harabagiu, 2004).
C04-1100
For example, techniques for speeding up uni cation in HPSG lead to dramatic improvements in ef ciency (Kiefer et al., 1999).
P99-1061
addition to bestrst parsing, the TRIPS parser uses a chart size limit, to prevent the parser from running too long on unparseable utterances, similar to (Frank et al., 2003).
P03-1014
Likewise ambiguity packing and CFG backbone parsing (Maxwell and Kaplan, 1994; van Noord, 1997) are known to increase parsing ef ciency.
J97-3004
Much work has been done related to enhancing the ef ciency of deep interpretation systems (Copestake and Flickinger, 2000; Swift et al., 2004; Maxwell and Kaplan, 1994), which forms the foundation that we build on in this work.
C04-1055
The context free backbone allows for ef cient left corner predictions using a pre-compiled left corner prediction table, such as that described in (van Noord, 1997).
J97-3004
For our comparison we used an excerpt from the Monroe corpus that has been used in previous TRIPS research on parsing speed and accuracy (Swift et al., 2004) consisting of dialogues s2, s4, s16 and s17.
C04-1055
The TRIPS grammar (Dzikovska et al., 2005) is a wide-coverage uni cation grammar that has been used very successfully in several task-oriented dialogue systems.
W05-1525
These enhancements help parsing dialogue (both spoken and typed), but they signi cantly increase grammar ambiguity, a common concern in building grammars for robust parsing (Schneider and McCoy, 1998).
P98-2196
The feature structures prevent loops in uni cation, and we considered including certain grammatical features into backbone extraction as done in (Briscoe and Carroll, 1994).
P94-1040
We considered two possible techniques for speeding up parsing: speeding up uni cation using the techniques similar to the LINGO system (Copestake and Flickinger, 2000), or using backbone extraction (Maxwell and Kaplan, 1994; Ros·e and Lavie, 2001; Briscoe and Carroll, 1994).
P94-1040
Its left corner chart parsing algorithm is similar to that described by Briscoe and Carroll (1994).
P94-1040
