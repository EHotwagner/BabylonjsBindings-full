#!/usr/bin/env bash
set -euo pipefail

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
WORK_ID="004-m2-finite-dependent-maps"
READINESS="$ROOT/readiness/$WORK_ID"

jq -e '
  .schemaVersion == 1 and
  .workId == "004-m2-finite-dependent-maps" and
  .status == "shipReady" and
  .readiness == "shipReady" and
  .generator == "FS.GG.SDD.Artifacts/1.5.0" and
  (.sourcesDigest.algorithm == "sha256") and
  (.sourcesDigest.value | test("^[0-9a-f]{64}$")) and
  .verificationReadiness.status == "verificationReady" and
  .verificationReadiness.evidenceSupportedCount == 19 and
  .verificationReadiness.evidenceSelfAttestedCount == 0 and
  .verificationReadiness.evidenceObservedCount == 19 and
  .disposition.state == "shipReady" and
  (.disposition.blockingFindingIds | length) == 0
' "$READINESS/ship-verdict.json" >/dev/null

printf '%s\n' '{"workId":"004-m2-finite-dependent-maps","verification":"verificationReady","supported":19,"observed":19,"selfAttested":0,"synthetic":0,"ship":"shipReady","blockingFindings":0,"durableVerdict":"readiness/004-m2-finite-dependent-maps/ship-verdict.json"}'
