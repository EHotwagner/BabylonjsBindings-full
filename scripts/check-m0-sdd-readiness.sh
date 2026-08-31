#!/usr/bin/env bash
set -euo pipefail

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
WORK_ID="002-m0-analysis-infrastructure"
READINESS="$ROOT/readiness/$WORK_ID"

jq -e '
  .schemaVersion == 1 and
  .workId == "002-m0-analysis-infrastructure" and
  .status == "shipReady" and
  .readiness == "shipReady" and
  .generator == "FS.GG.SDD.Artifacts/1.5.0" and
  (.sourcesDigest.algorithm == "sha256") and
  (.sourcesDigest.value | test("^[0-9a-f]{64}$")) and
  .verificationReadiness.status == "verificationReady" and
  .verificationReadiness.evidenceSupportedCount == 8 and
  .verificationReadiness.evidenceObservedCount == 8 and
  .disposition.state == "shipReady" and
  (.disposition.blockingFindingIds | length) == 0
' "$READINESS/ship-verdict.json" >/dev/null

printf '%s\n' '{"workId":"002-m0-analysis-infrastructure","verification":"verificationReady","supported":8,"observed":8,"synthetic":0,"ship":"shipReady","blockingFindings":0,"durableVerdict":"readiness/002-m0-analysis-infrastructure/ship-verdict.json"}'
