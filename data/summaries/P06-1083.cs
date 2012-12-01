A number of corpus-based methods are used to extract bilingual lexicons (Fung and McKeown, 1996; Smadja, 1996).
J96-1001
In an attempt to extract Chinese–English translations from corpora, Lam et al.(2004) proposed a similar method to Fujii et al.(2004). However, they searched the Web for Chinese–English bilingual comparable corpora, and matched named entities in each language corpus if they were similar to each other.
W04-1809
Fourth, as performed by Fujii et al.(2004), we use a Japanese Katakana dictionary and extract a candidate loanword that is phonetically similar to a Katakana word as a loanword.
W04-1809
However, unlike Fujii et al.(2004), we use N-gram retrieval to limit the number of Katakana words that are similar to the candidate loanwords.
W04-1809
Thus, Fujii et al.(2004) extracted the loanwords in Korean corpora that were phonetically similar to Japanese Katakana words.
W04-1809
Fujii et al.(2004) proposed a method that does not require tagged corpora or parallel corpora to extract loanwords and their translations.
W04-1809
3.1 Overview In view of the discussion outlined in Section 2, we enhanced the method proposed by Fujii et al.(2004) for our purpose.
W04-1809
In contrast, using Fujii et al.’s (2004) method, the Katakana dictionary and a Korean corpus can be independent.
W04-1809
Although the basis of our method is similar to that used by Fujii et al.(2004), “Stemming”, “Extracting loanwords based on rules”, and “N-gram retrieval” are introduced in this paper.
W04-1809
