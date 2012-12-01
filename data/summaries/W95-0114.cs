Because it was divided into two parts to form a non-parallel corpus, it is also half in size to the parallel corpus used for word alignment (Wu 181 & Xia 1994).
A94-1030 P94-1012
We have previously shown an algorithm which extracts a bilingual lexicon from noisy parallel corpus without sentence alignment (Fung & McKeown 1994; Fung 1995).
C94-2178 P95-1032
In parallel corpora, this feature could be the positional co-occurrence of a word and its translation in the other language in the same sentences (Kupiec 1993; Smadja & McKeown 1994; Kumano & Hirakawa 1994; Dagan et al.1993; Wu & Xia 1994) or in the same segments (Fung & Church 1994; Fung 1995).
A94-1030 C94-1009 C94-2178 H94-1027 P93-1003 P94-1012 P95-1032 W93-0301
Non-parallel Corpus of Chinese and English We use parts of the HKUST English-Chinese Bilingual Corpora for our experiments (Wu 1994), consisting of transcriptions of the Hong Kong Legislative Council debates in both English and Chinese.
A94-1030 P94-1012
Wu, DEKAI & PASCALE FLING, 1994.
A94-1030 P94-1012
Most previous automatic lexicon compilation techniques require a sentence-aligned clean parallel bilingual corpus (Kupiec 1993; Smadja & McKeown 1994; Kumano & Hirakawa 1994; Dagan et al.1993; Wu & Xia 1994).
A94-1030 C94-1009 H94-1027 P93-1003 P94-1012 W93-0301
Table 3: Test set words part one English word Chinese word possible Chinese POS Basic British CHIM CHOW CHOW China Committee Council Declaration Financial Government Governor ~N N N N N'N Hong Kong LAM LAU Law Ltd ~N N~N McGREGOR Mr ~N October +~ SECURITY t~ Second .~-~ TAM TU ~± WONG YIU noun noun-adj ambiguous ambiguous ambiguous noun-adj noun ambiguous noun-verb noun-adj noun-adj noun proper noun proper noun ambiguous proper noun noun noun ambiguous noun noun noun-verb noun proper noun ambiguous ambiguous ambiguous 7.1 Effect of Chinese Tokenization We used a statistically augmented Chinese tokenizer for finding word boundaries in the Chinese text (Fung & Wu 1994; Wu & Fung 1994).
A94-1030 C94-2178 P94-1012
We obtained a cluster of Chinese words centered around ~-~ by applying the Kvec segment cooccurrence score (Fung & Church 1994) on the Chinese text with itself.
C94-2178
In Fung & McKeown (1994); Fung (1995), the word feature used was the positional difference vector.
C94-2178 P95-1032
